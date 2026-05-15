
namespace ArcadeMaker.IDE
{
    partial class GameScriptEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.scriptBox = new ArcadeMaker.IDE.GSScriptBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.errorBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(53, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(159, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // scriptBox
            // 
            this.scriptBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptBox.Location = new System.Drawing.Point(15, 32);
            this.scriptBox.Name = "scriptBox";
            this.scriptBox.SelectionLength = 0;
            this.scriptBox.SelectionStart = 0;
            this.scriptBox.Size = new System.Drawing.Size(816, 350);
            this.scriptBox.TabIndex = 2;
            this.scriptBox.TextChanged += new System.EventHandler<System.EventArgs>(this.scriptBox_TextChanged);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBtn.Location = new System.Drawing.Point(15, 478);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // errorBox
            // 
            this.errorBox.FormattingEnabled = true;
            this.errorBox.Location = new System.Drawing.Point(15, 389);
            this.errorBox.Name = "errorBox";
            this.errorBox.Size = new System.Drawing.Size(816, 82);
            this.errorBox.TabIndex = 4;
            // 
            // GameScriptEditor
            // 
            //this.Icon = Properties.Resources.ArcadeMaker_icon;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 512);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.scriptBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "GameScriptEditor";
            this.Text = "Script Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameScriptEditor_FormClosed);
            this.Load += new System.EventHandler(this.GameScriptEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private GSScriptBox scriptBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ListBox errorBox;
    }
}