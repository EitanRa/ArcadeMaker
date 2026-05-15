
using ArcadeMaker.IDE.Properties;

namespace ArcadeMaker.IDE
{
    partial class SpansTextBox2SearchForm
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.matchCaseBox = new System.Windows.Forms.CheckBox();
            this.findNextBtn = new System.Windows.Forms.Button();
            this.replaceNextBtn = new System.Windows.Forms.Button();
            this.replaceAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(89, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace With";
            // 
            // replaceBox
            // 
            this.replaceBox.Location = new System.Drawing.Point(90, 38);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(99, 20);
            this.replaceBox.TabIndex = 2;
            // 
            // matchCaseBox
            // 
            this.matchCaseBox.AutoSize = true;
            this.matchCaseBox.Location = new System.Drawing.Point(15, 77);
            this.matchCaseBox.Name = "matchCaseBox";
            this.matchCaseBox.Size = new System.Drawing.Size(83, 17);
            this.matchCaseBox.TabIndex = 4;
            this.matchCaseBox.Text = "Match Case";
            this.matchCaseBox.UseVisualStyleBackColor = true;
            // 
            // findNextBtn
            // 
            this.findNextBtn.Location = new System.Drawing.Point(12, 116);
            this.findNextBtn.Name = "findNextBtn";
            this.findNextBtn.Size = new System.Drawing.Size(177, 23);
            this.findNextBtn.TabIndex = 5;
            this.findNextBtn.Text = "Find Next";
            this.findNextBtn.UseVisualStyleBackColor = true;
            this.findNextBtn.Click += new System.EventHandler(this.findNextBtn_Click);
            // 
            // replaceNextBtn
            // 
            this.replaceNextBtn.Location = new System.Drawing.Point(12, 145);
            this.replaceNextBtn.Name = "replaceNextBtn";
            this.replaceNextBtn.Size = new System.Drawing.Size(86, 23);
            this.replaceNextBtn.TabIndex = 6;
            this.replaceNextBtn.Text = "Replace Next";
            this.replaceNextBtn.UseVisualStyleBackColor = true;
            this.replaceNextBtn.Click += new System.EventHandler(this.replaceNextBtn_Click);
            // 
            // replaceAllBtn
            // 
            this.replaceAllBtn.Location = new System.Drawing.Point(103, 145);
            this.replaceAllBtn.Name = "replaceAllBtn";
            this.replaceAllBtn.Size = new System.Drawing.Size(86, 23);
            this.replaceAllBtn.TabIndex = 7;
            this.replaceAllBtn.Text = "Replace All";
            this.replaceAllBtn.UseVisualStyleBackColor = true;
            this.replaceAllBtn.Click += new System.EventHandler(this.replaceAllBtn_Click);
            // 
            // GSScriptBoxSearchForm
            // 
            this.Icon = Resources.ResourceManager.GetObject("ArcadeMaker_icon") as Icon;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 179);
            this.Controls.Add(this.replaceAllBtn);
            this.Controls.Add(this.replaceNextBtn);
            this.Controls.Add(this.findNextBtn);
            this.Controls.Add(this.matchCaseBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GSScriptBoxSearchForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SpansTextBox2SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.CheckBox matchCaseBox;
        private System.Windows.Forms.Button findNextBtn;
        private System.Windows.Forms.Button replaceNextBtn;
        private System.Windows.Forms.Button replaceAllBtn;
    }
}