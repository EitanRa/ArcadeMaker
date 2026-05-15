
namespace ArcadeMaker.IDE
{
    partial class SelectEventDialog
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
            this.components = new System.ComponentModel.Container();
            this.keyDownBtn = new System.Windows.Forms.Button();
            this.keyUpBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.stepBtn = new System.Windows.Forms.Button();
            this.mouseMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mouseDownBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mousePressBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseUpBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.mouseWheelBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.drawBtn = new System.Windows.Forms.Button();
            this.keyPressBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.alarmBtn = new System.Windows.Forms.Button();
            this.mouseMenuBtn = new System.Windows.Forms.Button();
            this.mouseMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // keyDownBtn
            // 
            this.keyDownBtn.Location = new System.Drawing.Point(12, 34);
            this.keyDownBtn.Name = "keyDownBtn";
            this.keyDownBtn.Size = new System.Drawing.Size(185, 23);
            this.keyDownBtn.TabIndex = 0;
            this.keyDownBtn.Text = "Key Down";
            this.keyDownBtn.UseVisualStyleBackColor = true;
            this.keyDownBtn.Click += new System.EventHandler(this.keyDownBtn_Click);
            // 
            // keyUpBtn
            // 
            this.keyUpBtn.Location = new System.Drawing.Point(12, 63);
            this.keyUpBtn.Name = "keyUpBtn";
            this.keyUpBtn.Size = new System.Drawing.Size(185, 23);
            this.keyUpBtn.TabIndex = 1;
            this.keyUpBtn.Text = "Key Release";
            this.keyUpBtn.UseVisualStyleBackColor = true;
            this.keyUpBtn.Click += new System.EventHandler(this.keyUpBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(12, 5);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(185, 23);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // stepBtn
            // 
            this.stepBtn.Location = new System.Drawing.Point(12, 121);
            this.stepBtn.Name = "stepBtn";
            this.stepBtn.Size = new System.Drawing.Size(185, 23);
            this.stepBtn.TabIndex = 3;
            this.stepBtn.Text = "Step";
            this.stepBtn.UseVisualStyleBackColor = true;
            this.stepBtn.Click += new System.EventHandler(this.stepBtn_Click);
            // 
            // mouseMenu
            // 
            this.mouseMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseDownBtn,
            this.mousePressBtn,
            this.mouseUpBtn,
            this.mouseWheelBtn});
            this.mouseMenu.Name = "mouseMenu";
            this.mouseMenu.Size = new System.Drawing.Size(192, 92);
            // 
            // mouseDownBtn
            // 
            this.mouseDownBtn.Name = "mouseDownBtn";
            this.mouseDownBtn.Size = new System.Drawing.Size(191, 22);
            this.mouseDownBtn.Text = "Mouse Button Down";
            this.mouseDownBtn.Click += new System.EventHandler(this.mouseDownBtn_Click);
            // 
            // mousePressBtn
            // 
            this.mousePressBtn.Name = "mousePressBtn";
            this.mousePressBtn.Size = new System.Drawing.Size(191, 22);
            this.mousePressBtn.Text = "Mouse Button Press";
            this.mousePressBtn.Click += new System.EventHandler(this.mousePressBtn_Click);
            // 
            // mouseUpBtn
            // 
            this.mouseUpBtn.Name = "mouseUpBtn";
            this.mouseUpBtn.Size = new System.Drawing.Size(191, 22);
            this.mouseUpBtn.Text = "Mouse Button Release";
            this.mouseUpBtn.Click += new System.EventHandler(this.mouseUpBtn_Click);
            // 
            // mouseWheelBtn
            // 
            this.mouseWheelBtn.Name = "mouseWheelBtn";
            this.mouseWheelBtn.Size = new System.Drawing.Size(191, 22);
            this.mouseWheelBtn.Text = "Mouse Wheel";
            this.mouseWheelBtn.Click += new System.EventHandler(this.mouseWheelBtn_Click);
            // 
            // drawBtn
            // 
            this.drawBtn.Location = new System.Drawing.Point(13, 179);
            this.drawBtn.Name = "drawBtn";
            this.drawBtn.Size = new System.Drawing.Size(185, 23);
            this.drawBtn.TabIndex = 5;
            this.drawBtn.Text = "Draw";
            this.drawBtn.UseVisualStyleBackColor = true;
            this.drawBtn.Click += new System.EventHandler(this.drawBtn_Click);
            // 
            // keyPressBtn
            // 
            this.keyPressBtn.Location = new System.Drawing.Point(12, 92);
            this.keyPressBtn.Name = "keyPressBtn";
            this.keyPressBtn.Size = new System.Drawing.Size(185, 23);
            this.keyPressBtn.TabIndex = 6;
            this.keyPressBtn.Text = "Key Press";
            this.keyPressBtn.UseVisualStyleBackColor = true;
            this.keyPressBtn.Click += new System.EventHandler(this.keyPressBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 292);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(185, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // alarmBtn
            // 
            this.alarmBtn.Location = new System.Drawing.Point(13, 208);
            this.alarmBtn.Name = "alarmBtn";
            this.alarmBtn.Size = new System.Drawing.Size(185, 23);
            this.alarmBtn.TabIndex = 9;
            this.alarmBtn.Text = "Alarm";
            this.alarmBtn.UseVisualStyleBackColor = true;
            this.alarmBtn.Click += new System.EventHandler(this.alarmBtn_Click);
            // 
            // mouseMenuBtn
            // 
            this.mouseMenuBtn.ContextMenuStrip = this.mouseMenu;
            this.mouseMenuBtn.Location = new System.Drawing.Point(12, 150);
            this.mouseMenuBtn.Name = "mouseMenuBtn";
            this.mouseMenuBtn.Size = new System.Drawing.Size(185, 23);
            this.mouseMenuBtn.TabIndex = 4;
            this.mouseMenuBtn.Text = "Mouse";
            this.mouseMenuBtn.UseVisualStyleBackColor = true;
            this.mouseMenuBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mouseMenuBtn_MouseClick);
            // 
            // SelectEventDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 327);
            this.Controls.Add(this.alarmBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.keyPressBtn);
            this.Controls.Add(this.drawBtn);
            this.Controls.Add(this.mouseMenuBtn);
            this.Controls.Add(this.stepBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.keyUpBtn);
            this.Controls.Add(this.keyDownBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectEventDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Event";
            this.Load += new System.EventHandler(this.SelectEventDialog_Load);
            this.mouseMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button keyDownBtn;
        private System.Windows.Forms.Button keyUpBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button stepBtn;
        private System.Windows.Forms.Button drawBtn;
        private System.Windows.Forms.Button keyPressBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button alarmBtn;
        private System.Windows.Forms.ContextMenuStrip mouseMenu;
        private System.Windows.Forms.ToolStripMenuItem mouseDownBtn;
        private System.Windows.Forms.ToolStripMenuItem mousePressBtn;
        private System.Windows.Forms.ToolStripMenuItem mouseUpBtn;
        private System.Windows.Forms.ToolStripMenuItem mouseWheelBtn;
        private System.Windows.Forms.Button mouseMenuBtn;
    }
}