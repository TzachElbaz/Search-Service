namespace searching_service_v._2
{
    partial class Form1
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
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelSearching = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(29, 93);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(283, 31);
            this.txtFileName.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(29, 174);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(283, 31);
            this.txtPath.TabIndex = 1;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(29, 65);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(90, 25);
            this.labelFileName.TabIndex = 2;
            this.labelFileName.Text = "File Name";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(29, 146);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(128, 25);
            this.labelPath.TabIndex = 2;
            this.labelPath.Text = "Searching Path";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(29, 225);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 34);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.HorizontalScrollbar = true;
            this.listResults.ItemHeight = 25;
            this.listResults.Location = new System.Drawing.Point(357, 50);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(582, 254);
            this.listResults.TabIndex = 4;
            this.listResults.DoubleClick += new System.EventHandler(this.listResults_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Results";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(200, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelSearching
            // 
            this.labelSearching.AutoSize = true;
            this.labelSearching.Location = new System.Drawing.Point(118, 279);
            this.labelSearching.Name = "labelSearching";
            this.labelSearching.Size = new System.Drawing.Size(101, 25);
            this.labelSearching.TabIndex = 7;
            this.labelSearching.Text = "Searching...";
            this.labelSearching.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 336);
            this.Controls.Add(this.labelSearching);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtFileName);
            this.MaximumSize = new System.Drawing.Size(1001, 392);
            this.MinimumSize = new System.Drawing.Size(1001, 392);
            this.Name = "Form1";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labelSearching;
    }
}

