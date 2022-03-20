﻿namespace dagorlz
{
    partial class dagorlz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dagorlz));
            this.selectDir = new System.Windows.Forms.Button();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.inputName = new System.Windows.Forms.TextBox();
            this.labelDetail1 = new System.Windows.Forms.Label();
            this.labelDetail2 = new System.Windows.Forms.Label();
            this.labelDetail3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.searchBFS = new System.Windows.Forms.Button();
            this.chosenDir = new System.Windows.Forms.TextBox();
            this.searchDFS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hyperlink = new System.Windows.Forms.LinkLabel();
            this.algorithmtime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectDir
            // 
            this.selectDir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.selectDir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectDir.Location = new System.Drawing.Point(366, 187);
            this.selectDir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectDir.Name = "selectDir";
            this.selectDir.Size = new System.Drawing.Size(124, 29);
            this.selectDir.TabIndex = 0;
            this.selectDir.Text = "Select Directory ...";
            this.selectDir.UseVisualStyleBackColor = false;
            this.selectDir.Click += new System.EventHandler(this.selectDir_Click);
            // 
            // checkAll
            // 
            this.checkAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkAll.AutoSize = true;
            this.checkAll.BackColor = System.Drawing.Color.Transparent;
            this.checkAll.Location = new System.Drawing.Point(619, 231);
            this.checkAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(160, 24);
            this.checkAll.TabIndex = 1;
            this.checkAll.Text = "Find All Occurences";
            this.checkAll.UseVisualStyleBackColor = false;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // graphPanel
            // 
            this.graphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.graphPanel.BackColor = System.Drawing.SystemColors.Control;
            this.graphPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graphPanel.Location = new System.Drawing.Point(45, 416);
            this.graphPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(734, 298);
            this.graphPanel.TabIndex = 2;
            this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphPanel_Paint);
            // 
            // inputName
            // 
            this.inputName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inputName.BackColor = System.Drawing.SystemColors.Info;
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputName.ForeColor = System.Drawing.Color.Black;
            this.inputName.Location = new System.Drawing.Point(366, 230);
            this.inputName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "  ex.: \"legenda_siluman_epi.pdf\"";
            this.inputName.Size = new System.Drawing.Size(247, 27);
            this.inputName.TabIndex = 9;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // labelDetail1
            // 
            this.labelDetail1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDetail1.AutoSize = true;
            this.labelDetail1.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDetail1.Location = new System.Drawing.Point(51, 187);
            this.labelDetail1.Name = "labelDetail1";
            this.labelDetail1.Size = new System.Drawing.Size(241, 25);
            this.labelDetail1.TabIndex = 10;
            this.labelDetail1.Text = "1. Choose starting directory";
            // 
            // labelDetail2
            // 
            this.labelDetail2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDetail2.AutoSize = true;
            this.labelDetail2.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDetail2.Location = new System.Drawing.Point(51, 232);
            this.labelDetail2.Name = "labelDetail2";
            this.labelDetail2.Size = new System.Drawing.Size(153, 25);
            this.labelDetail2.TabIndex = 11;
            this.labelDetail2.Text = "2. Input filename";
            this.labelDetail2.Click += new System.EventHandler(this.labelDetail2_Click);
            // 
            // labelDetail3
            // 
            this.labelDetail3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDetail3.AutoSize = true;
            this.labelDetail3.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDetail3.Location = new System.Drawing.Point(51, 277);
            this.labelDetail3.Name = "labelDetail3";
            this.labelDetail3.Size = new System.Drawing.Size(191, 25);
            this.labelDetail3.TabIndex = 12;
            this.labelDetail3.Text = "3. Pick search method";
            // 
            // searchBFS
            // 
            this.searchBFS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchBFS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBFS.Location = new System.Drawing.Point(366, 271);
            this.searchBFS.Name = "searchBFS";
            this.searchBFS.Size = new System.Drawing.Size(78, 37);
            this.searchBFS.TabIndex = 13;
            this.searchBFS.Text = "BFS";
            this.searchBFS.UseVisualStyleBackColor = true;
            this.searchBFS.Click += new System.EventHandler(this.searchBFS_Click);
            // 
            // chosenDir
            // 
            this.chosenDir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chosenDir.BackColor = System.Drawing.SystemColors.Info;
            this.chosenDir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenDir.Location = new System.Drawing.Point(496, 189);
            this.chosenDir.Name = "chosenDir";
            this.chosenDir.PlaceholderText = "No directory chosen";
            this.chosenDir.ReadOnly = true;
            this.chosenDir.Size = new System.Drawing.Size(283, 25);
            this.chosenDir.TabIndex = 14;
            this.chosenDir.TextChanged += new System.EventHandler(this.chosenDir_TextChanged);
            // 
            // searchDFS
            // 
            this.searchDFS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchDFS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchDFS.Location = new System.Drawing.Point(468, 271);
            this.searchDFS.Name = "searchDFS";
            this.searchDFS.Size = new System.Drawing.Size(78, 37);
            this.searchDFS.TabIndex = 15;
            this.searchDFS.Text = "DFS";
            this.searchDFS.UseVisualStyleBackColor = true;
            this.searchDFS.Click += new System.EventHandler(this.searchDFS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 174);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(51, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "4. Graph speed interval";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trackBar1.Location = new System.Drawing.Point(360, 327);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(309, 56);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 18;
            this.trackBar1.TabStop = false;
            this.trackBar1.TickFrequency = 100;
            this.trackBar1.Value = 500;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "5. Graph";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 737);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "6. Algorithm Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 780);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "7. Hyperlink";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(422, 737);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "ms";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(713, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "ms";
            // 
            // hyperlink
            // 
            this.hyperlink.AutoSize = true;
            this.hyperlink.Location = new System.Drawing.Point(366, 785);
            this.hyperlink.Name = "hyperlink";
            this.hyperlink.Size = new System.Drawing.Size(69, 20);
            this.hyperlink.TabIndex = 28;
            this.hyperlink.TabStop = true;
            this.hyperlink.Text = "hyperlink";
            // 
            // algorithmtime
            // 
            this.algorithmtime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.algorithmtime.AutoSize = true;
            this.algorithmtime.BackColor = System.Drawing.Color.Transparent;
            this.algorithmtime.Location = new System.Drawing.Point(366, 741);
            this.algorithmtime.Name = "algorithmtime";
            this.algorithmtime.Size = new System.Drawing.Size(17, 20);
            this.algorithmtime.TabIndex = 29;
            this.algorithmtime.Text = "0";
            this.algorithmtime.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(679, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "500";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dagorlz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(837, 826);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.algorithmtime);
            this.Controls.Add(this.hyperlink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchDFS);
            this.Controls.Add(this.chosenDir);
            this.Controls.Add(this.searchBFS);
            this.Controls.Add(this.labelDetail3);
            this.Controls.Add(this.labelDetail2);
            this.Controls.Add(this.labelDetail1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.selectDir);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(855, 873);
            this.Name = "dagorlz";
            this.Text = "Dagorlz";
            this.Load += new System.EventHandler(this.Dagorlz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectDir;
        private CheckBox checkAll;
        private Panel graphPanel;
        private TextBox inputName;
        private Label labelDetail1;
        private Label labelDetail2;
        private Label labelDetail3;
        private FolderBrowserDialog folderBrowserDialog;
        private Button searchBFS;
        private TextBox chosenDir;
        private Button searchDFS;
        private PictureBox pictureBox1;
        private Label label1;
        private TrackBar trackBar1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private LinkLabel hyperlink;
        private Label algorithmtime;
        private Label label8;
    }
}