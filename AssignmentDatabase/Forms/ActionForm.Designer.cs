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
            this.SuspendLayout();
            // 
            // addDeviceTypeButton
            // 
            this.addDeviceTypeButton.Location = new System.Drawing.Point(70, 23);
            this.addDeviceTypeButton.Name = "addDeviceTypeButton";
            this.addDeviceTypeButton.Size = new System.Drawing.Size(133, 89);
            this.addDeviceTypeButton.TabIndex = 0;
            this.addDeviceTypeButton.Text = "Thêm loại thiết bị";
            this.addDeviceTypeButton.UseVisualStyleBackColor = true;
            this.addDeviceTypeButton.Click += new System.EventHandler(this.addDeviceTypeButton_Click);
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(311, 23);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(133, 89);
            this.addDeviceButton.TabIndex = 1;
            this.addDeviceButton.Text = "Thêm thiết bị";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            this.addDeviceButton.Click += new System.EventHandler(this.addDeviceButton_Click);
            // 
            // ActionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.addDeviceTypeButton);
            this.Name = "ActionForm";
            this.Text = "Thao Tác";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDeviceTypeButton;
        private System.Windows.Forms.Button addDeviceButton;
    }
}