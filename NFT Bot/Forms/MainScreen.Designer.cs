namespace NFT_Bot {
    partial class MainScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbInstant = new System.Windows.Forms.RadioButton();
            this.rbTrigger = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPostfix = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbShowImage = new System.Windows.Forms.RadioButton();
            this.rbHideImage = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCollectionName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSortRank = new System.Windows.Forms.RadioButton();
            this.rbSortPrice = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.rbShowListedOnly = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbRankAuto = new System.Windows.Forms.RadioButton();
            this.rbRankRegex = new System.Windows.Forms.RadioButton();
            this.btnFetch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ncLastID = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nftsList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProgress2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLastID)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPostfix);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txtCollectionName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbRankAuto);
            this.groupBox1.Controls.Add(this.rbRankRegex);
            this.groupBox1.Controls.Add(this.btnFetch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ncLastID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApi);
            this.groupBox1.Location = new System.Drawing.Point(67, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbInstant);
            this.groupBox5.Controls.Add(this.rbTrigger);
            this.groupBox5.Location = new System.Drawing.Point(71, 68);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(294, 35);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            // 
            // rbInstant
            // 
            this.rbInstant.AutoSize = true;
            this.rbInstant.Checked = true;
            this.rbInstant.Location = new System.Drawing.Point(6, 11);
            this.rbInstant.Name = "rbInstant";
            this.rbInstant.Size = new System.Drawing.Size(57, 17);
            this.rbInstant.TabIndex = 25;
            this.rbInstant.TabStop = true;
            this.rbInstant.Text = "Instant";
            this.rbInstant.UseVisualStyleBackColor = true;
            // 
            // rbTrigger
            // 
            this.rbTrigger.AutoSize = true;
            this.rbTrigger.Location = new System.Drawing.Point(69, 11);
            this.rbTrigger.Name = "rbTrigger";
            this.rbTrigger.Size = new System.Drawing.Size(58, 17);
            this.rbTrigger.TabIndex = 24;
            this.rbTrigger.Text = "Trigger";
            this.rbTrigger.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mode :";
            // 
            // txtPostfix
            // 
            this.txtPostfix.Location = new System.Drawing.Point(305, 46);
            this.txtPostfix.Name = "txtPostfix";
            this.txtPostfix.Size = new System.Drawing.Size(60, 20);
            this.txtPostfix.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Postfix :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbShowImage);
            this.groupBox4.Controls.Add(this.rbHideImage);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(379, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 54);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Images";
            // 
            // rbShowImage
            // 
            this.rbShowImage.AutoSize = true;
            this.rbShowImage.Location = new System.Drawing.Point(69, 27);
            this.rbShowImage.Name = "rbShowImage";
            this.rbShowImage.Size = new System.Drawing.Size(52, 17);
            this.rbShowImage.TabIndex = 17;
            this.rbShowImage.Text = "Show";
            this.rbShowImage.UseVisualStyleBackColor = true;
            // 
            // rbHideImage
            // 
            this.rbHideImage.AutoSize = true;
            this.rbHideImage.Checked = true;
            this.rbHideImage.Location = new System.Drawing.Point(134, 27);
            this.rbHideImage.Name = "rbHideImage";
            this.rbHideImage.Size = new System.Drawing.Size(47, 17);
            this.rbHideImage.TabIndex = 18;
            this.rbHideImage.TabStop = true;
            this.rbHideImage.Text = "Hide";
            this.rbHideImage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Sort By :";
            // 
            // txtCollectionName
            // 
            this.txtCollectionName.Location = new System.Drawing.Point(71, 108);
            this.txtCollectionName.Name = "txtCollectionName";
            this.txtCollectionName.Size = new System.Drawing.Size(294, 20);
            this.txtCollectionName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Collection :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSortRank);
            this.groupBox3.Controls.Add(this.rbSortPrice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(379, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 54);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sorting";
            // 
            // rbSortRank
            // 
            this.rbSortRank.AutoSize = true;
            this.rbSortRank.Checked = true;
            this.rbSortRank.Location = new System.Drawing.Point(69, 27);
            this.rbSortRank.Name = "rbSortRank";
            this.rbSortRank.Size = new System.Drawing.Size(51, 17);
            this.rbSortRank.TabIndex = 17;
            this.rbSortRank.TabStop = true;
            this.rbSortRank.Text = "Rank";
            this.rbSortRank.UseVisualStyleBackColor = true;
            this.rbSortRank.CheckedChanged += new System.EventHandler(this.rbSortRank_CheckedChanged);
            // 
            // rbSortPrice
            // 
            this.rbSortPrice.AutoSize = true;
            this.rbSortPrice.Location = new System.Drawing.Point(134, 27);
            this.rbSortPrice.Name = "rbSortPrice";
            this.rbSortPrice.Size = new System.Drawing.Size(49, 17);
            this.rbSortPrice.TabIndex = 18;
            this.rbSortPrice.Text = "Price";
            this.rbSortPrice.UseVisualStyleBackColor = true;
            this.rbSortPrice.CheckedChanged += new System.EventHandler(this.rbSortPrice_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sort By :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rbShowAll);
            this.groupBox2.Controls.Add(this.rbShowListedOnly);
            this.groupBox2.Location = new System.Drawing.Point(379, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 54);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtering";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Show : ";
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Location = new System.Drawing.Point(69, 23);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(36, 17);
            this.rbShowAll.TabIndex = 12;
            this.rbShowAll.Text = "All";
            this.rbShowAll.UseVisualStyleBackColor = true;
            this.rbShowAll.CheckedChanged += new System.EventHandler(this.rbShowAll_CheckedChanged);
            // 
            // rbShowListedOnly
            // 
            this.rbShowListedOnly.AutoSize = true;
            this.rbShowListedOnly.Checked = true;
            this.rbShowListedOnly.Location = new System.Drawing.Point(134, 23);
            this.rbShowListedOnly.Name = "rbShowListedOnly";
            this.rbShowListedOnly.Size = new System.Drawing.Size(77, 17);
            this.rbShowListedOnly.TabIndex = 11;
            this.rbShowListedOnly.TabStop = true;
            this.rbShowListedOnly.Text = "Listed Only";
            this.rbShowListedOnly.UseVisualStyleBackColor = true;
            this.rbShowListedOnly.CheckedChanged += new System.EventHandler(this.rbShowListedOnly_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ranking Type :";
            // 
            // rbRankAuto
            // 
            this.rbRankAuto.AutoSize = true;
            this.rbRankAuto.Checked = true;
            this.rbRankAuto.Location = new System.Drawing.Point(291, 137);
            this.rbRankAuto.Name = "rbRankAuto";
            this.rbRankAuto.Size = new System.Drawing.Size(47, 17);
            this.rbRankAuto.TabIndex = 6;
            this.rbRankAuto.TabStop = true;
            this.rbRankAuto.Text = "Auto";
            this.rbRankAuto.UseVisualStyleBackColor = true;
            // 
            // rbRankRegex
            // 
            this.rbRankRegex.AutoSize = true;
            this.rbRankRegex.Location = new System.Drawing.Point(229, 137);
            this.rbRankRegex.Name = "rbRankRegex";
            this.rbRankRegex.Size = new System.Drawing.Size(56, 17);
            this.rbRankRegex.TabIndex = 5;
            this.rbRankRegex.Text = "Regex";
            this.rbRankRegex.UseVisualStyleBackColor = true;
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(174, 166);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(81, 23);
            this.btnFetch.TabIndex = 4;
            this.btnFetch.Text = "Fetch";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last ID :";
            // 
            // ncLastID
            // 
            this.ncLastID.Location = new System.Drawing.Point(72, 137);
            this.ncLastID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ncLastID.Name = "ncLastID";
            this.ncLastID.Size = new System.Drawing.Size(65, 20);
            this.ncLastID.TabIndex = 2;
            this.ncLastID.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "API Url :";
            // 
            // txtApi
            // 
            this.txtApi.Location = new System.Drawing.Point(71, 46);
            this.txtApi.Name = "txtApi";
            this.txtApi.Size = new System.Drawing.Size(184, 20);
            this.txtApi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "NFT SNIPER";
            // 
            // nftsList
            // 
            this.nftsList.AutoScroll = true;
            this.nftsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nftsList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.nftsList.Location = new System.Drawing.Point(67, 270);
            this.nftsList.Name = "nftsList";
            this.nftsList.Size = new System.Drawing.Size(630, 322);
            this.nftsList.TabIndex = 1;
            this.nftsList.WrapContents = false;
            // 
            // lblProgress2
            // 
            this.lblProgress2.AutoSize = true;
            this.lblProgress2.Location = new System.Drawing.Point(64, 604);
            this.lblProgress2.Name = "lblProgress2";
            this.lblProgress2.Size = new System.Drawing.Size(149, 13);
            this.lblProgress2.TabIndex = 3;
            this.lblProgress2.Text = "Current Api Token : 1 / 10000";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 22);
            this.btnSave.Text = "Save Ranks";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Files (*.txt) | *.txt";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(752, 627);
            this.Controls.Add(this.lblProgress2);
            this.Controls.Add(this.nftsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "NFT Sniper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncLastID)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ncLastID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbRankAuto;
        private System.Windows.Forms.RadioButton rbRankRegex;
        private System.Windows.Forms.FlowLayoutPanel nftsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbShowListedOnly;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbSortRank;
        private System.Windows.Forms.RadioButton rbSortPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCollectionName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbShowImage;
        private System.Windows.Forms.RadioButton rbHideImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblProgress2;
        private System.Windows.Forms.TextBox txtPostfix;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbInstant;
        private System.Windows.Forms.RadioButton rbTrigger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

