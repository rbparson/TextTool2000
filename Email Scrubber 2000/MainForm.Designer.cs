namespace Email_Scrubber_2000
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button6 = new System.Windows.Forms.Button();
            this.BtnSaveFilteredList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnScrub = new System.Windows.Forms.Button();
            this.BtnLoadEmailList = new System.Windows.Forms.Button();
            this.BtnLoadBlackList = new System.Windows.Forms.Button();
            this.WhiteListFileName = new System.Windows.Forms.Label();
            this.BtnLoadWhiteList = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DomainScrubCount = new System.Windows.Forms.Label();
            this.WhiteListDomainCount = new System.Windows.Forms.Label();
            this.TotalScrubCount = new System.Windows.Forms.Label();
            this.TotalKeepCount = new System.Windows.Forms.Label();
            this.LinesToScrubLabel = new System.Windows.Forms.Label();
            this.LinesToKeepLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RawListBox = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ScrubListBox = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.WhiteListBox = new System.Windows.Forms.ListBox();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.RawListBoxCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "Filter Control Panel";
            this.panel1.AccessibleName = "FilterPanel";
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.BtnSaveFilteredList);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.BtnScrub);
            this.panel1.Controls.Add(this.BtnLoadEmailList);
            this.panel1.Controls.Add(this.BtnLoadBlackList);
            this.panel1.Controls.Add(this.WhiteListFileName);
            this.panel1.Controls.Add(this.BtnLoadWhiteList);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.ListNameLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(16, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 461);
            this.panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 279);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(185, 37);
            this.progressBar1.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(17, 407);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(186, 38);
            this.button6.TabIndex = 13;
            this.button6.Text = "Save White List";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // BtnSaveFilteredList
            // 
            this.BtnSaveFilteredList.AccessibleName = "BtnSaveFilteredList";
            this.BtnSaveFilteredList.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveFilteredList.Location = new System.Drawing.Point(17, 362);
            this.BtnSaveFilteredList.Name = "BtnSaveFilteredList";
            this.BtnSaveFilteredList.Size = new System.Drawing.Size(186, 39);
            this.BtnSaveFilteredList.TabIndex = 12;
            this.BtnSaveFilteredList.Text = "Save Filtered Email List As...";
            this.BtnSaveFilteredList.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AccessibleName = "Export";
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Export";
            // 
            // label8
            // 
            this.label8.AccessibleName = "DomainBlackListName";
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Feature Coming Soon!";
            // 
            // BtnScrub
            // 
            this.BtnScrub.AccessibleName = "BtnScrub";
            this.BtnScrub.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnScrub.Location = new System.Drawing.Point(17, 206);
            this.BtnScrub.Name = "BtnScrub";
            this.BtnScrub.Size = new System.Drawing.Size(186, 67);
            this.BtnScrub.TabIndex = 9;
            this.BtnScrub.Text = "SCRUB";
            this.BtnScrub.UseVisualStyleBackColor = true;
            this.BtnScrub.Click += new System.EventHandler(this.BtnScrub_Click);
            // 
            // BtnLoadEmailList
            // 
            this.BtnLoadEmailList.AccessibleName = "BtnLoadEmailList";
            this.BtnLoadEmailList.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadEmailList.Location = new System.Drawing.Point(18, 30);
            this.BtnLoadEmailList.Name = "BtnLoadEmailList";
            this.BtnLoadEmailList.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadEmailList.TabIndex = 8;
            this.BtnLoadEmailList.Text = "Load";
            this.BtnLoadEmailList.UseVisualStyleBackColor = true;
            this.BtnLoadEmailList.Click += new System.EventHandler(this.BtnLoadEmailList_Click);
            // 
            // BtnLoadBlackList
            // 
            this.BtnLoadBlackList.AccessibleName = "BtnLoadBlackList";
            this.BtnLoadBlackList.Enabled = false;
            this.BtnLoadBlackList.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadBlackList.Location = new System.Drawing.Point(19, 164);
            this.BtnLoadBlackList.Name = "BtnLoadBlackList";
            this.BtnLoadBlackList.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadBlackList.TabIndex = 7;
            this.BtnLoadBlackList.Text = "Load";
            this.BtnLoadBlackList.UseVisualStyleBackColor = true;
            // 
            // WhiteListFileName
            // 
            this.WhiteListFileName.AccessibleName = "WhiteListFileName";
            this.WhiteListFileName.AutoSize = true;
            this.WhiteListFileName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteListFileName.Location = new System.Drawing.Point(24, 110);
            this.WhiteListFileName.Name = "WhiteListFileName";
            this.WhiteListFileName.Size = new System.Drawing.Size(38, 15);
            this.WhiteListFileName.TabIndex = 6;
            this.WhiteListFileName.Text = "NONE";
            // 
            // BtnLoadWhiteList
            // 
            this.BtnLoadWhiteList.AccessibleName = "BtnLoadWhiteList";
            this.BtnLoadWhiteList.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoadWhiteList.Location = new System.Drawing.Point(19, 84);
            this.BtnLoadWhiteList.Name = "BtnLoadWhiteList";
            this.BtnLoadWhiteList.Size = new System.Drawing.Size(75, 23);
            this.BtnLoadWhiteList.TabIndex = 5;
            this.BtnLoadWhiteList.Text = "Load";
            this.BtnLoadWhiteList.UseVisualStyleBackColor = true;
            this.BtnLoadWhiteList.Click += new System.EventHandler(this.BtnLoadWhiteList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Domain Black List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Domain White List";
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.AccessibleName = "ListNameLabel";
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameLabel.Location = new System.Drawing.Point(115, 32);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(88, 18);
            this.ListNameLabel.TabIndex = 2;
            this.ListNameLabel.Text = "no list loaded";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AccessibleName = "EmailListLabel";
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "EMAIL SCRUBBER 2000";
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "Panel for displaying scrub statistics. Use this panel to review whitelist, and ma" +
    "ke filter changes if necessary.";
            this.panel2.AccessibleName = "DataPreviewPanel";
            this.panel2.Controls.Add(this.RawListBoxCount);
            this.panel2.Controls.Add(this.DomainScrubCount);
            this.panel2.Controls.Add(this.WhiteListDomainCount);
            this.panel2.Controls.Add(this.TotalScrubCount);
            this.panel2.Controls.Add(this.TotalKeepCount);
            this.panel2.Controls.Add(this.LinesToScrubLabel);
            this.panel2.Controls.Add(this.LinesToKeepLabel);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.RawListBox);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.ScrubListBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.WhiteListBox);
            this.panel2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(256, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 461);
            this.panel2.TabIndex = 1;
            // 
            // DomainScrubCount
            // 
            this.DomainScrubCount.AutoSize = true;
            this.DomainScrubCount.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainScrubCount.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.DomainScrubCount.Location = new System.Drawing.Point(471, 9);
            this.DomainScrubCount.Name = "DomainScrubCount";
            this.DomainScrubCount.Size = new System.Drawing.Size(24, 28);
            this.DomainScrubCount.TabIndex = 11;
            this.DomainScrubCount.Text = "0";
            // 
            // WhiteListDomainCount
            // 
            this.WhiteListDomainCount.AutoSize = true;
            this.WhiteListDomainCount.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteListDomainCount.ForeColor = System.Drawing.Color.Green;
            this.WhiteListDomainCount.Location = new System.Drawing.Point(199, 9);
            this.WhiteListDomainCount.Name = "WhiteListDomainCount";
            this.WhiteListDomainCount.Size = new System.Drawing.Size(24, 28);
            this.WhiteListDomainCount.TabIndex = 10;
            this.WhiteListDomainCount.Text = "0";
            // 
            // TotalScrubCount
            // 
            this.TotalScrubCount.AutoSize = true;
            this.TotalScrubCount.Location = new System.Drawing.Point(37, 206);
            this.TotalScrubCount.Name = "TotalScrubCount";
            this.TotalScrubCount.Size = new System.Drawing.Size(19, 22);
            this.TotalScrubCount.TabIndex = 9;
            this.TotalScrubCount.Text = "0";
            // 
            // TotalKeepCount
            // 
            this.TotalKeepCount.AutoSize = true;
            this.TotalKeepCount.Location = new System.Drawing.Point(37, 184);
            this.TotalKeepCount.Name = "TotalKeepCount";
            this.TotalKeepCount.Size = new System.Drawing.Size(19, 22);
            this.TotalKeepCount.TabIndex = 8;
            this.TotalKeepCount.Text = "0";
            // 
            // LinesToScrubLabel
            // 
            this.LinesToScrubLabel.AutoSize = true;
            this.LinesToScrubLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinesToScrubLabel.Location = new System.Drawing.Point(59, 206);
            this.LinesToScrubLabel.Name = "LinesToScrubLabel";
            this.LinesToScrubLabel.Size = new System.Drawing.Size(112, 18);
            this.LinesToScrubLabel.TabIndex = 7;
            this.LinesToScrubLabel.Text = "Lines To Be Scrub";
            // 
            // LinesToKeepLabel
            // 
            this.LinesToKeepLabel.AutoSize = true;
            this.LinesToKeepLabel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinesToKeepLabel.Location = new System.Drawing.Point(59, 184);
            this.LinesToKeepLabel.Name = "LinesToKeepLabel";
            this.LinesToKeepLabel.Size = new System.Drawing.Size(106, 18);
            this.LinesToKeepLabel.TabIndex = 6;
            this.LinesToKeepLabel.Text = "Lines To Be Kept";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 22);
            this.label12.TabIndex = 5;
            this.label12.Text = "Raw Data Lines That Will Be Scrubbed";
            // 
            // RawListBox
            // 
            this.RawListBox.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawListBox.FormattingEnabled = true;
            this.RawListBox.ItemHeight = 15;
            this.RawListBox.Location = new System.Drawing.Point(30, 263);
            this.RawListBox.Name = "RawListBox";
            this.RawListBox.Size = new System.Drawing.Size(495, 169);
            this.RawListBox.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(258, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Domains Scrubbed";
            // 
            // ScrubListBox
            // 
            this.ScrubListBox.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScrubListBox.FormattingEnabled = true;
            this.ScrubListBox.ItemHeight = 15;
            this.ScrubListBox.Location = new System.Drawing.Point(262, 50);
            this.ScrubListBox.Name = "ScrubListBox";
            this.ScrubListBox.Size = new System.Drawing.Size(263, 109);
            this.ScrubListBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = " White List Domains";
            // 
            // WhiteListBox
            // 
            this.WhiteListBox.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WhiteListBox.FormattingEnabled = true;
            this.WhiteListBox.ItemHeight = 15;
            this.WhiteListBox.Location = new System.Drawing.Point(27, 50);
            this.WhiteListBox.Name = "WhiteListBox";
            this.WhiteListBox.Size = new System.Drawing.Size(211, 109);
            this.WhiteListBox.TabIndex = 0;
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorMessage.Location = new System.Drawing.Point(279, 14);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(55, 22);
            this.ErrorMessage.TabIndex = 4;
            this.ErrorMessage.Text = "Error:";
            // 
            // RawListBoxCount
            // 
            this.RawListBoxCount.AutoSize = true;
            this.RawListBoxCount.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RawListBoxCount.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.RawListBoxCount.Location = new System.Drawing.Point(343, 225);
            this.RawListBoxCount.Name = "RawListBoxCount";
            this.RawListBoxCount.Size = new System.Drawing.Size(24, 28);
            this.RawListBoxCount.TabIndex = 12;
            this.RawListBoxCount.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 537);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Email Scrubber 2000";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLoadEmailList;
        private System.Windows.Forms.Button BtnLoadBlackList;
        private System.Windows.Forms.Label WhiteListFileName;
        private System.Windows.Forms.Button BtnLoadWhiteList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ListNameLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnSaveFilteredList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnScrub;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox ScrubListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox WhiteListBox;
        private System.Windows.Forms.Label TotalScrubCount;
        private System.Windows.Forms.Label TotalKeepCount;
        private System.Windows.Forms.Label LinesToScrubLabel;
        private System.Windows.Forms.Label LinesToKeepLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox RawListBox;
        private System.Windows.Forms.Label DomainScrubCount;
        private System.Windows.Forms.Label WhiteListDomainCount;
        private System.Windows.Forms.Label ErrorMessage;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label RawListBoxCount;
    }
}

