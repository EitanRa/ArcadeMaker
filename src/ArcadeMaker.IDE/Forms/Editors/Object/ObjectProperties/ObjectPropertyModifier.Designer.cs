namespace ArcadeMaker.IDE.Editors.Object.ObjectProperties
{
    partial class ObjectPropertyModifier
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
            NameBox = new TextBox();
            TypeBox = new ComboBox();
            InitValBox = new TextBox();
            ConstantBox = new CheckBox();
            PrivateBox = new CheckBox();
            NullableBox = new CheckBox();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Location = new Point(3, 3);
            NameBox.Name = "NameBox";
            NameBox.PlaceholderText = "Name";
            NameBox.Size = new Size(104, 23);
            NameBox.TabIndex = 0;
            NameBox.TextChanged += NameBox_TextChanged;
            // 
            // TypeBox
            // 
            TypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeBox.FormattingEnabled = true;
            TypeBox.Location = new Point(113, 3);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(85, 23);
            TypeBox.TabIndex = 1;
            TypeBox.SelectedIndexChanged += TypeBox_SelectedIndexChanged;
            // 
            // InitValBox
            // 
            InitValBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InitValBox.Location = new Point(204, 3);
            InitValBox.Name = "InitValBox";
            InitValBox.PlaceholderText = "Init Value";
            InitValBox.Size = new Size(78, 23);
            InitValBox.TabIndex = 2;
            InitValBox.Text = "null";
            InitValBox.TextChanged += InitValBox_TextChanged;
            // 
            // ConstantBox
            // 
            ConstantBox.AutoSize = true;
            ConstantBox.Location = new Point(3, 32);
            ConstantBox.Name = "ConstantBox";
            ConstantBox.Size = new Size(74, 19);
            ConstantBox.TabIndex = 3;
            ConstantBox.Text = "Constant";
            ConstantBox.UseVisualStyleBackColor = true;
            ConstantBox.CheckedChanged += ConstantBox_CheckedChanged;
            // 
            // PrivateBox
            // 
            PrivateBox.AutoSize = true;
            PrivateBox.Location = new Point(83, 32);
            PrivateBox.Name = "PrivateBox";
            PrivateBox.Size = new Size(62, 19);
            PrivateBox.TabIndex = 4;
            PrivateBox.Text = "Private";
            PrivateBox.UseVisualStyleBackColor = true;
            PrivateBox.CheckedChanged += PrivateBox_CheckedChanged;
            // 
            // NullableBox
            // 
            NullableBox.AutoSize = true;
            NullableBox.Location = new Point(151, 32);
            NullableBox.Name = "NullableBox";
            NullableBox.Size = new Size(70, 19);
            NullableBox.TabIndex = 5;
            NullableBox.Text = "Nullable";
            NullableBox.UseVisualStyleBackColor = true;
            NullableBox.CheckedChanged += NullableBox_CheckedChanged;
            // 
            // ObjectPropertyModifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(NullableBox);
            Controls.Add(PrivateBox);
            Controls.Add(ConstantBox);
            Controls.Add(InitValBox);
            Controls.Add(TypeBox);
            Controls.Add(NameBox);
            Name = "ObjectPropertyModifier";
            Size = new Size(285, 58);
            Load += ObjectPropertyModifier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private ComboBox TypeBox;
        private TextBox InitValBox;
        private CheckBox ConstantBox;
        private CheckBox PrivateBox;
        private CheckBox NullableBox;
    }
}
