namespace AssignmentDatabase.Forms
{
    partial class AddDeviceForm
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
            this.deviceTypeListBox = new System.Windows.Forms.ListBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberUpDown = new System.Windows.Forms.NumericUpDown();
            this.addDeviceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceTypeListBox
            // 
            this.deviceTypeListBox.FormattingEnabled = true;
            this.deviceTypeListBox.ItemHeight = 25;
            this.deviceTypeListBox.Location = new System.Drawing.Point(0, 50);
            this.deviceTypeListBox.Name = "deviceTypeListBox";
            this.deviceTypeListBox.Size = new System.Drawing.Size(116, 329);
            this.deviceTypeListBox.TabIndex = 0;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(309, 44);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 31);
            this.codeTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(309, 119);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 31);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // numberUpDown
            // 
            this.numberUpDown.Location = new System.Drawing.Point(309, 192);
            this.numberUpDown.Name = "numberUpDown";
            this.numberUpDown.Size = new System.Drawing.Size(120, 31);
            this.numberUpDown.TabIndex = 8;
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(309, 277);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(120, 44);
            this.addDeviceButton.TabIndex = 9;
            this.addDeviceButton.Text = "Thêm";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.numberUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.deviceTypeListBox);
            this.Name = "AddDeviceForm";
            this.Text = "AddDevice";
            this.Load += new System.EventHandler(this.AddDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deviceTypeListBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numberUpDown;
        private System.Windows.Forms.Button addDeviceButton;
    }
}