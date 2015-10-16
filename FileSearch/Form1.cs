using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace FileSearch
{
    public partial class Form1 : Form
    {
        DateTime dt;
        int filesProcessed;
        List<string> foundFiles;
        CancellationTokenSource cts;
        TreeNode ancestorNode;
        List<string> commonNodeNames;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Выберите исходный каталог";
            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxInitialFolder.Text = fbd.SelectedPath;
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            SaveParameters();            
            filesProcessed = 0;
            dt = new DateTime(0);
            labelProcessed.Text = "0";
            labelTime.Text = dt.ToString("HH:mm:ss");
            foundFiles = new List<string>();
            treeView1.Nodes.Clear();
            ancestorNode = null;
            CreateTree(textBoxInitialFolder.Text, ref ancestorNode);
            string[] commonNodeNamesArr = textBoxInitialFolder.Text.Split('\\');
            commonNodeNames = new List<string>(commonNodeNamesArr);
            buttonStop.Enabled = true;
            buttonSearch.Enabled = false;
            cts = new CancellationTokenSource();
            timer1.Start();
            try
            {
                await SearchInFolder(textBoxInitialFolder.Text, cts.Token);
            }
            catch (AggregateException ae)
            {
                foreach (Exception ex in ae.InnerExceptions)
                {
                    if (ex is TaskCanceledException)
                        MessageBox.Show("поиск был отменен: " + ex.Message);
                    else
                        MessageBox.Show("Exception: " + ex.GetType().Name);
                }
            }
            catch (OperationCanceledException oce)
            {
                MessageBox.Show(oce.Message);
            }
            /*catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }*/
            finally
            {
                cts.Dispose();
            }
            timer1.Stop();
            buttonSearch.Enabled = true;
            buttonStop.Enabled = false;
        }

        private async Task SearchInFolder(string folderPath, CancellationToken ct)
        {
            foreach (string dir in Directory.GetDirectories(folderPath))
                try
                {
                    await SearchInFolder(dir, ct);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            bool first = true;
            TreeNode folderNode = null;
            List<string> suitableFiles = Directory.GetFiles(folderPath, textBoxFilenameTemplate.Text).ToList();
            foreach (string filename in Directory.GetFiles(folderPath))
            {
                try
                {
                    labelProcessing.Text = filename;
                    if (ct.IsCancellationRequested)
                    {
                        ct.ThrowIfCancellationRequested();
                    }
                    if (suitableFiles.Contains(filename))
                    {
                        using (StreamReader reader = new StreamReader(filename))
                        {
                            string s = await reader.ReadToEndAsync();
                            if (s.IndexOf(textBoxText.Text) > -1)
                            {
                                if (first)
                                {
                                    string[] temp = folderPath.Split('\\');
                                    List<string> folderNodesList = new List<string>(temp);
                                    for (int i = 0; i < commonNodeNames.Count; i++)
                                        folderNodesList.RemoveAt(0);
                                    CreateNode(folderNodesList, ref ancestorNode, ref folderNode);
                                    first = false;
                                }
                                foundFiles.Add(filename);
                                folderNode.Nodes.Add(filename.Substring(filename.LastIndexOf('\\') + 1));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
                filesProcessed++;
                labelProcessed.Text = filesProcessed.ToString();
            }
        }

        private void CreateTree(string path, ref TreeNode lastNode)
        {
            string[] nodeNames = path.Split('\\');
            TreeNode root = treeView1.Nodes.Add(nodeNames[0]);
            List<string> nodeNamesList = new List<string>(nodeNames);
            nodeNamesList.RemoveAt(0);
            CreateNode(nodeNamesList, ref root, ref lastNode);
        }

        private void CreateNode(List<string> nodeNames, ref TreeNode parent, ref TreeNode lastNode)
        {
            TreeNode newNode;
            if (nodeNames.Count > 0)
                newNode = parent.Nodes.Add(nodeNames[0]);
            else
                newNode = parent;
            if (nodeNames.Count > 1)
            {
                nodeNames.RemoveAt(0);
                CreateNode(nodeNames, ref newNode, ref lastNode);
            }
            else
            {
                lastNode = newNode;
                return;
            }
        }

        private void SaveParameters()
        {
            using (FileStream fs = new FileStream(Environment.CurrentDirectory + "\\config", FileMode.Create, FileAccess.Write, FileShare.None))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(textBoxInitialFolder.Text);
                sw.WriteLine(textBoxFilenameTemplate.Text);
                sw.WriteLine(textBoxText.Text);
            }
        }

        private void LoadParameters()
        {
            using(FileStream fs = new FileStream(Environment.CurrentDirectory + "\\config", FileMode.Open, FileAccess.Read, FileShare.None))
            using (StreamReader sr = new StreamReader(fs))
            {
                textBoxInitialFolder.Text = sr.ReadLine();
                textBoxFilenameTemplate.Text = sr.ReadLine();
                textBoxText.Text = sr.ReadLine();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadParameters();
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt = dt.AddSeconds(1);
            labelTime.Text = dt.ToString("HH:mm:ss");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
            buttonSearch.Enabled = true;
            buttonStop.Enabled = false;
        }
    }
}
