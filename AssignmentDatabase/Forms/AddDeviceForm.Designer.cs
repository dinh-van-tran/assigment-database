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
            this.label5 = new System.Windows.Forms.Label();
            this.valueUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceTypeListBox
            // 
            this.deviceTypeListBox.FormattingEnabled = true;
            this.deviceTypeListBox.Location = new System.Drawing.Point(0, 26);
            this.deviceTypeListBox.Margin = new System.Windows.Forms.Padding(2);
            this.deviceTypeListBox.Name = "deviceTypeListBox";
            this.deviceTypeListBox.Size = new System.Drawing.Size(209, 342);
            this.deviceTypeListBox.TabIndex = 0;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(354, 41);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(86, 20);
            this.codeTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(354, 80);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(86, 39);
            this.descriptionTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ghi chú";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số lượng";
            // 
            // numberUpDown
            // 
            this.numberUpDown.Location = new System.Drawing.Point(326, 303);
            this.numberUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.numberUpDown.Name = "numberUpDown";
            this.numberUpDown.Size = new System.Drawing.Size(87, 20);
            this.numberUpDown.TabIndex = 8;
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(337, 336);
            this.addDeviceButton.Margin = new System.Windows.Forms.Padding(2);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(60, 23);
            this.addDeviceButton.TabIndex = 9;
            this.addDeviceButton.Text = "Thêm";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá trị";
            // 
            // valueUpDown
            // 
            this.valueUpDown.Location = new System.Drawing.Point(323, 277);
            this.valueUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.valueUpDown.Name = "valueUpDown";
            this.valueUpDown.Size = new System.Drawing.Size(90, 20);
            this.valueUpDown.TabIndex = 12;
            // 
            // AddDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 430);
            this.Controls.Add(this.valueUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.numberUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.deviceTypeListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDeviceForm";
            this.Text = "AddDevice";
            this.Load += new System.EventHandler(this.AddDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUpDown)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown valueUpDown;
    }
}