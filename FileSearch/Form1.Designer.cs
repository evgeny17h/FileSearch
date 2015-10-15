namespace FileSearch
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.textBoxInitialFolder = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFilenameTemplate = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.labelProcessed = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 26);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(237, 373);
            this.treeView1.TabIndex = 0;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(537, 3);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(101, 23);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "Выбрать папку";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // textBoxInitialFolder
            // 
            this.textBoxInitialFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxInitialFolder.Location = new System.Drawing.Point(203, 5);
            this.textBoxInitialFolder.Name = "textBoxInitialFolder";
            this.textBoxInitialFolder.Size = new System.Drawing.Size(261, 20);
            this.textBoxInitialFolder.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxInitialFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonSelectFolder, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilenameTemplate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxText, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSearch, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelProcessing, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelProcessed, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelTime, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonStop, 2, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(271, 168);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(685, 210);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Исходная папка";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Шаблон имени";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Текст в файле";
            // 
            // textBoxFilenameTemplate
            // 
            this.textBoxFilenameTemplate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFilenameTemplate.Location = new System.Drawing.Point(203, 35);
            this.textBoxFilenameTemplate.Name = "textBoxFilenameTemplate";
            this.textBoxFilenameTemplate.Size = new System.Drawing.Size(216, 20);
            this.textBoxFilenameTemplate.TabIndex = 6;
            // 
            // textBoxText
            // 
            this.textBoxText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxText.Location = new System.Drawing.Point(203, 65);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(188, 20);
            this.textBoxText.TabIndex = 7;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(203, 93);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Обрабатывается";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Обработано файлов";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Прошло";
            // 
            // labelProcessing
            // 
            this.labelProcessing.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.Location = new System.Drawing.Point(203, 128);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(58, 13);
            this.labelProcessing.TabIndex = 12;
            this.labelProcessing.Text = "processing";
            // 
            // labelProcessed
            // 
            this.labelProcessed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelProcessed.AutoSize = true;
            this.labelProcessed.Location = new System.Drawing.Point(203, 158);
            this.labelProcessed.Name = "labelProcessed";
            this.labelProcessed.Size = new System.Drawing.Size(56, 13);
            this.labelProcessed.TabIndex = 13;
            this.labelProcessed.Text = "processed";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(203, 188);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(43, 13);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "time left";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(537, 93);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "Остановить";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "FileSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxInitialFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFilenameTemplate;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Label labelProcessed;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonStop;
    }
}

