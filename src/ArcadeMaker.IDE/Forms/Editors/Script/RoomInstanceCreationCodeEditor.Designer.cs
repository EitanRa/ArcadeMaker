
namespace ArcadeMaker.IDE
{
    partial class RoomInstanceCreationCodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomInstanceCreationCodeEditor));
            this.codeBox = new ArcadeMaker.IDE.GSScriptBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.resetCodeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(13, 37);
            this.codeBox.Name = "codeBox";
            this.codeBox.SelectionLength = 0;
            this.codeBox.SelectionStart = 0;
            this.codeBox.Size = new System.Drawing.Size(775, 345);
            this.codeBox.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(13, 415);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetCodeBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // resetCodeBtn
            // 
            this.resetCodeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resetCodeBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetCodeBtn.Image")));
            this.resetCodeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetCodeBtn.Name = "resetCodeBtn";
            this.resetCodeBtn.Size = new System.Drawing.Size(23, 22);
            this.resetCodeBtn.Text = "↶";
            this.resetCodeBtn.Click += new System.EventHandler(this.resetCodeBtn_Click);
            // 
            // RoomInstanceCreationCodeEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.codeBox);
            this.Name = "RoomInstanceCreationCodeEditor";
            this.Text = "Edit creation code for instance of object";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RoomInstanceCreationCodeEditor_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GSScriptBox codeBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton resetCodeBtn;
    }
}