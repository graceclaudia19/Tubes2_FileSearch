namespace dagorlz
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
            this.mainLogo = new System.Windows.Forms.Label();
            this.subLogo = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.labelDetail1 = new System.Windows.Forms.Label();
            this.labelDetail2 = new System.Windows.Forms.Label();
            this.labelDetail3 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.searchBFS = new System.Windows.Forms.Button();
            this.chosenDir = new System.Windows.Forms.TextBox();
            this.searchDFS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectDir
            // 
            this.selectDir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectDir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectDir.Location = new System.Drawing.Point(47, 193);
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
            this.checkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkAll.AutoSize = true;
            this.checkAll.BackColor = System.Drawing.Color.Transparent;
            this.checkAll.Location = new System.Drawing.Point(47, 371);
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
            this.graphPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPanel.BackColor = System.Drawing.SystemColors.Control;
            this.graphPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.graphPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.graphPanel.Location = new System.Drawing.Point(340, 12);
            this.graphPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(611, 534);
            this.graphPanel.TabIndex = 2;
            // 
            // mainLogo
            // 
            this.mainLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLogo.AutoSize = true;
            this.mainLogo.BackColor = System.Drawing.Color.Transparent;
            this.mainLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainLogo.Font = new System.Drawing.Font("Papyrus", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mainLogo.Location = new System.Drawing.Point(39, 29);
            this.mainLogo.Name = "mainLogo";
            this.mainLogo.Size = new System.Drawing.Size(248, 76);
            this.mainLogo.TabIndex = 5;
            this.mainLogo.Text = "Dagorlz    ";
            // 
            // subLogo
            // 
            this.subLogo.AutoSize = true;
            this.subLogo.BackColor = System.Drawing.Color.Transparent;
            this.subLogo.Font = new System.Drawing.Font("Tempus Sans ITC", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.subLogo.Location = new System.Drawing.Point(179, 82);
            this.subLogo.Name = "subLogo";
            this.subLogo.Size = new System.Drawing.Size(101, 19);
            this.subLogo.TabIndex = 6;
            this.subLogo.Text = "Folder Crawler";
            // 
            // inputName
            // 
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.inputName.BackColor = System.Drawing.SystemColors.Desktop;
            this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputName.ForeColor = System.Drawing.Color.Black;
            this.inputName.Location = new System.Drawing.Point(47, 332);
            this.inputName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "  ex.: \"legenda_siluman_epi.pdf\"";
            this.inputName.Size = new System.Drawing.Size(247, 27);
            this.inputName.TabIndex = 9;
            this.inputName.TextChanged += new System.EventHandler(this.inputName_TextChanged);
            // 
            // labelDetail1
            // 
            this.labelDetail1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetail1.AutoSize = true;
            this.labelDetail1.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDetail1.Location = new System.Drawing.Point(39, 157);
            this.labelDetail1.Name = "labelDetail1";
            this.labelDetail1.Size = new System.Drawing.Size(241, 25);
            this.labelDetail1.TabIndex = 10;
            this.labelDetail1.Text = "1. Choose starting directory";
            // 
            // labelDetail2
            // 
            this.labelDetail2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetail2.AutoSize = true;
            this.labelDetail2.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDetail2.Location = new System.Drawing.Point(39, 295);
            this.labelDetail2.Name = "labelDetail2";
            this.labelDetail2.Size = new System.Drawing.Size(153, 25);
            this.labelDetail2.TabIndex = 11;
            this.labelDetail2.Text = "2. Input filename";
            // 
            // labelDetail3
            // 
            this.labelDetail3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDetail3.AutoSize = true;
            this.labelDetail3.BackColor = System.Drawing.Color.Transparent;
            this.labelDetail3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDetail3.Location = new System.Drawing.Point(39, 434);
            this.labelDetail3.Name = "labelDetail3";
            this.labelDetail3.Size = new System.Drawing.Size(191, 25);
            this.labelDetail3.TabIndex = 12;
            this.labelDetail3.Text = "3. Pick search method";
            // 
            // searchBFS
            // 
            this.searchBFS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBFS.Location = new System.Drawing.Point(47, 464);
            this.searchBFS.Name = "searchBFS";
            this.searchBFS.Size = new System.Drawing.Size(78, 37);
            this.searchBFS.TabIndex = 13;
            this.searchBFS.Text = "BFS";
            this.searchBFS.UseVisualStyleBackColor = true;
            this.searchBFS.Click += new System.EventHandler(this.searchBFS_Click);
            // 
            // chosenDir
            // 
            this.chosenDir.BackColor = System.Drawing.SystemColors.Desktop;
            this.chosenDir.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chosenDir.Location = new System.Drawing.Point(47, 227);
            this.chosenDir.Name = "chosenDir";
            this.chosenDir.PlaceholderText = "No directory chosen";
            this.chosenDir.ReadOnly = true;
            this.chosenDir.Size = new System.Drawing.Size(247, 25);
            this.chosenDir.TabIndex = 14;
            // 
            // searchDFS
            // 
            this.searchDFS.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchDFS.Location = new System.Drawing.Point(152, 464);
            this.searchDFS.Name = "searchDFS";
            this.searchDFS.Size = new System.Drawing.Size(78, 37);
            this.searchDFS.TabIndex = 15;
            this.searchDFS.Text = "DFS";
            this.searchDFS.UseVisualStyleBackColor = true;
            this.searchDFS.Click += new System.EventHandler(this.searchDFS_Click);
            // 
            // dagorlz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 571);
            this.Controls.Add(this.searchDFS);
            this.Controls.Add(this.chosenDir);
            this.Controls.Add(this.searchBFS);
            this.Controls.Add(this.labelDetail3);
            this.Controls.Add(this.labelDetail2);
            this.Controls.Add(this.labelDetail1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.subLogo);
            this.Controls.Add(this.mainLogo);
            this.Controls.Add(this.graphPanel);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.selectDir);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(981, 618);
            this.Name = "dagorlz";
            this.Text = "Dagorlz";
            this.Load += new System.EventHandler(this.Dagorlz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button selectDir;
        private CheckBox checkAll;
        private Panel graphPanel;
        private Label mainLogo;
        private Label subLogo;
        private TextBox inputName;
        private Label labelDetail1;
        private Label labelDetail2;
        private Label labelDetail3;
        private FolderBrowserDialog folderBrowserDialog;
        private Button searchBFS;
        private TextBox chosenDir;
        private Button searchDFS;
    }
}