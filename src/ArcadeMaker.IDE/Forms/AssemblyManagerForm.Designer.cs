namespace ArcadeMaker.IDE
{
    partial class AssemblyManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssemblyManagerForm));
            this.assembliesBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.browseDocFileBtn = new System.Windows.Forms.Button();
            this.docFilePathBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.includeAsEmbeddedResBox = new System.Windows.Forms.CheckBox();
            this.browseDllBtn = new System.Windows.Forms.Button();
            this.dllPathBox = new System.Windows.Forms.TextBox();
            this.assemblyNameBox = new System.Windows.Forms.TextBox();
            this.assemblyNameRBtn = new System.Windows.Forms.RadioButton();
            this.dllPathRBtn = new System.Windows.Forms.RadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assembliesBox
            // 
            this.assembliesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assembliesBox.FormattingEnabled = true;
            this.assembliesBox.Location = new System.Drawing.Point(12, 12);
            this.assembliesBox.Name = "assembliesBox";
            this.assembliesBox.Size = new System.Drawing.Size(596, 225);
            this.assembliesBox.TabIndex = 0;
            this.assembliesBox.SelectedIndexChanged += new System.EventHandler(this.assembliesBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.browseDocFileBtn);
            this.groupBox1.Controls.Add(this.docFilePathBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.includeAsEmbeddedResBox);
            this.groupBox1.Controls.Add(this.browseDllBtn);
            this.groupBox1.Controls.Add(this.dllPathBox);
            this.groupBox1.Controls.Add(this.assemblyNameBox);
            this.groupBox1.Controls.Add(this.assemblyNameRBtn);
            this.groupBox1.Controls.Add(this.dllPathRBtn);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reference Settings";
            // 
            // browseDocFileBtn
            // 
            this.browseDocFileBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseDocFileBtn.Location = new System.Drawing.Point(515, 96);
            this.browseDocFileBtn.Name = "browseDocFileBtn";
            this.browseDocFileBtn.Size = new System.Drawing.Size(75, 23);
            this.browseDocFileBtn.TabIndex = 8;
            this.browseDocFileBtn.Text = "Browse";
            this.browseDocFileBtn.UseVisualStyleBackColor = true;
            this.browseDocFileBtn.Click += new System.EventHandler(this.browseDocFileBtn_Click);
            // 
            // docFilePathBox
            // 
            this.docFilePathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.docFilePathBox.Location = new System.Drawing.Point(201, 98);
            this.docFilePathBox.Name = "docFilePathBox";
            this.docFilePathBox.Size = new System.Drawing.Size(308, 20);
            this.docFilePathBox.TabIndex = 7;
            this.docFilePathBox.TextChanged += new System.EventHandler(this.docFilePathBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "C# Documentation File Path (optional):";
            // 
            // includeAsEmbeddedResBox
            // 
            this.includeAsEmbeddedResBox.AutoSize = true;
            this.includeAsEmbeddedResBox.Location = new System.Drawing.Point(6, 71);
            this.includeAsEmbeddedResBox.Name = "includeAsEmbeddedResBox";
            this.includeAsEmbeddedResBox.Size = new System.Drawing.Size(228, 17);
            this.includeAsEmbeddedResBox.TabIndex = 5;
            this.includeAsEmbeddedResBox.Text = "Include And Load As Embedded Resource";
            this.includeAsEmbeddedResBox.UseVisualStyleBackColor = true;
            this.includeAsEmbeddedResBox.CheckedChanged += new System.EventHandler(this.includeAsEmbeddedResBox_CheckedChanged);
            // 
            // browseDllBtn
            // 
            this.browseDllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseDllBtn.Location = new System.Drawing.Point(515, 16);
            this.browseDllBtn.Name = "browseDllBtn";
            this.browseDllBtn.Size = new System.Drawing.Size(75, 23);
            this.browseDllBtn.TabIndex = 4;
            this.browseDllBtn.Text = "Browse";
            this.browseDllBtn.UseVisualStyleBackColor = true;
            this.browseDllBtn.Click += new System.EventHandler(this.browseDllBtn_Click);
            // 
            // dllPathBox
            // 
            this.dllPathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dllPathBox.Location = new System.Drawing.Point(115, 18);
            this.dllPathBox.Name = "dllPathBox";
            this.dllPathBox.Size = new System.Drawing.Size(394, 20);
            this.dllPathBox.TabIndex = 3;
            this.dllPathBox.TextChanged += new System.EventHandler(this.dllPathBox_TextChanged);
            // 
            // assemblyNameBox
            // 
            this.assemblyNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assemblyNameBox.Location = new System.Drawing.Point(115, 45);
            this.assemblyNameBox.Name = "assemblyNameBox";
            this.assemblyNameBox.Size = new System.Drawing.Size(475, 20);
            this.assemblyNameBox.TabIndex = 2;
            this.assemblyNameBox.TextChanged += new System.EventHandler(this.assemblyNameBox_TextChanged);
            // 
            // assemblyNameRBtn
            // 
            this.assemblyNameRBtn.AutoSize = true;
            this.assemblyNameRBtn.Enabled = false;
            this.assemblyNameRBtn.Location = new System.Drawing.Point(6, 46);
            this.assemblyNameRBtn.Name = "assemblyNameRBtn";
            this.assemblyNameRBtn.Size = new System.Drawing.Size(103, 17);
            this.assemblyNameRBtn.TabIndex = 1;
            this.assemblyNameRBtn.TabStop = true;
            this.assemblyNameRBtn.Text = "Assembly Name:";
            this.assemblyNameRBtn.UseVisualStyleBackColor = true;
            this.assemblyNameRBtn.CheckedChanged += new System.EventHandler(this.assemblyNameRBtn_CheckedChanged);
            // 
            // dllPathRBtn
            // 
            this.dllPathRBtn.AutoSize = true;
            this.dllPathRBtn.Checked = true;
            this.dllPathRBtn.Location = new System.Drawing.Point(6, 19);
            this.dllPathRBtn.Name = "dllPathRBtn";
            this.dllPathRBtn.Size = new System.Drawing.Size(92, 17);
            this.dllPathRBtn.TabIndex = 0;
            this.dllPathRBtn.TabStop = true;
            this.dllPathRBtn.Text = "DLL File Path:";
            this.dllPathRBtn.UseVisualStyleBackColor = true;
            this.dllPathRBtn.CheckedChanged += new System.EventHandler(this.dllPathRBtn_CheckedChanged);
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.okBtn.Location = new System.Drawing.Point(18, 428);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(99, 428);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(424, 382);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(103, 23);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add Reference";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeBtn.Enabled = false;
            this.removeBtn.Location = new System.Drawing.Point(533, 382);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(75, 23);
            this.removeBtn.TabIndex = 5;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // AssemblyManagerForm
            // 
            this.AcceptButton = this.okBtn;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(620, 463);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.assembliesBox);
            this.Name = "AssemblyManagerForm";
            this.Text = "Assembly Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssemblyManagerForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox assembliesBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton assemblyNameRBtn;
        private System.Windows.Forms.RadioButton dllPathRBtn;
        private System.Windows.Forms.Button browseDllBtn;
        private System.Windows.Forms.TextBox dllPathBox;
        private System.Windows.Forms.TextBox assemblyNameBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox includeAsEmbeddedResBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button browseDocFileBtn;
        private System.Windows.Forms.TextBox docFilePathBox;
        private System.Windows.Forms.Label label1;
    }
}
