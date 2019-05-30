namespace AssignmentDatabase.Forms
{
    partial class ActionForm
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
            this.addDeviceTypeButton = new System.Windows.Forms.Button();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDeviceTypeButton
            // 
            this.addDeviceTypeButton.Location = new System.Drawing.Point(38, 328);
            this.addDeviceTypeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addDeviceTypeButton.Name = "addDeviceTypeButton";
            this.addDeviceTypeButton.Size = new System.Drawing.Size(137, 66);
            this.addDeviceTypeButton.TabIndex = 0;
            this.addDeviceTypeButton.Text = "Thêm loại thiết bị";
            this.addDeviceTypeButton.UseVisualStyleBackColor = true;
            this.addDeviceTypeButton.Click += new System.EventHandler(this.addDeviceTypeButton_Click);
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(416, 328);
            this.addDeviceButton.Margin = new System.Windows.Forms.Padding(2);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(126, 66);
            this.addDeviceButton.TabIndex = 1;
            this.addDeviceButton.Text = "Thêm thiết bị";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Quản Lý Nhân Viên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 66);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 454);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.addDeviceTypeButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ActionForm";
            this.Text = "Phần Mềm Quản Lý Thiết Bị";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDeviceTypeButton;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}