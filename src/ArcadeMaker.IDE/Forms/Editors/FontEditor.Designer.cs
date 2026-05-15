
namespace ArcadeMaker.IDE
{
    partial class FontEditor
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
            this.label2 = new System.Windows.Forms.Label();
            this.familiesBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.NumericUpDown();
            this.boldBox = new System.Windows.Forms.CheckBox();
            this.italicBox = new System.Windows.Forms.CheckBox();
            this.previewLbl = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBox)).BeginInit();
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
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(53, 6);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(116, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font";
            // 
            // familiesBox
            // 
            this.familiesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.familiesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familiesBox.FormattingEnabled = true;
            this.familiesBox.Location = new System.Drawing.Point(53, 60);
            this.familiesBox.Name = "familiesBox";
            this.familiesBox.Size = new System.Drawing.Size(116, 21);
            this.familiesBox.TabIndex = 3;
            this.familiesBox.SelectedIndexChanged += new System.EventHandler(this.familiesBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size";
            // 
            // sizeBox
            // 
            this.sizeBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeBox.Location = new System.Drawing.Point(53, 87);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(116, 20);
            this.sizeBox.TabIndex = 5;
            this.sizeBox.ValueChanged += new System.EventHandler(this.sizeBox_ValueChanged);
            // 
            // boldBox
            // 
            this.boldBox.AutoSize = true;
            this.boldBox.Location = new System.Drawing.Point(15, 125);
            this.boldBox.Name = "boldBox";
            this.boldBox.Size = new System.Drawing.Size(47, 17);
            this.boldBox.TabIndex = 6;
            this.boldBox.Text = "Bold";
            this.boldBox.UseVisualStyleBackColor = true;
            this.boldBox.CheckedChanged += new System.EventHandler(this.boldBox_CheckedChanged);
            // 
            // italicBox
            // 
            this.italicBox.AutoSize = true;
            this.italicBox.Location = new System.Drawing.Point(91, 125);
            this.italicBox.Name = "italicBox";
            this.italicBox.Size = new System.Drawing.Size(48, 17);
            this.italicBox.TabIndex = 7;
            this.italicBox.Text = "Italic";
            this.italicBox.UseVisualStyleBackColor = true;
            this.italicBox.CheckedChanged += new System.EventHandler(this.italicBox_CheckedChanged);
            // 
            // previewLbl
            // 
            this.previewLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewLbl.Location = new System.Drawing.Point(12, 169);
            this.previewLbl.Name = "previewLbl";
            this.previewLbl.Size = new System.Drawing.Size(157, 100);
            this.previewLbl.TabIndex = 8;
            this.previewLbl.Text = "AaBbCcDd";
            this.previewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(53, 281);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // FontEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 316);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.previewLbl);
            this.Controls.Add(this.italicBox);
            this.Controls.Add(this.boldBox);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.familiesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Name = "FontEditor";
            this.Text = "Font Properties";
            this.Load += new System.EventHandler(this.FontEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox familiesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sizeBox;
        private System.Windows.Forms.CheckBox boldBox;
        private System.Windows.Forms.CheckBox italicBox;
        private System.Windows.Forms.Label previewLbl;
        private System.Windows.Forms.Button okBtn;
    }
}