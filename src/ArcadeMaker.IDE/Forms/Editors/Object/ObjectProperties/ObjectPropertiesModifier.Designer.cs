namespace ArcadeMaker.IDE.Editors.Object.ObjectProperties
{
    partial class ObjectPropertiesModifier
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddBtn = new Button();
            groupBox = new GroupBox();
            panel = new Panel();
            DeleteBtn = new Button();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddBtn.Location = new Point(3, 292);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(315, 23);
            AddBtn.TabIndex = 0;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // groupBox
            // 
            groupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox.Controls.Add(panel);
            groupBox.Location = new Point(3, 3);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 283);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Properties";
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel.AutoScroll = true;
            panel.Location = new Point(6, 22);
            panel.Name = "panel";
            panel.Size = new Size(303, 255);
            panel.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DeleteBtn.Enabled = false;
            DeleteBtn.Location = new Point(3, 321);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(315, 23);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete Selected Properties";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ObjectPropertiesModifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteBtn);
            Controls.Add(groupBox);
            Controls.Add(AddBtn);
            Name = "ObjectPropertiesModifier";
            Size = new Size(325, 347);
            Load += ObjectPropertiesModifier_Load;
            groupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddBtn;
        private GroupBox groupBox;
        private Button DeleteBtn;
        private Panel panel;
    }
}
