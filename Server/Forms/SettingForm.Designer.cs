namespace Server.Forms
{
    partial class SettingForm
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
            this.TestFolderTextBox = new System.Windows.Forms.TextBox();
            this.TestFolderLabel = new System.Windows.Forms.Label();
            this.PortLabelTextBox = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.SaveConfigButton = new System.Windows.Forms.Button();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IpLabel = new System.Windows.Forms.Label();
            this.ResultFolderLabel = new System.Windows.Forms.Label();
            this.ResultFolderTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestFolderTextBox
            // 
            this.TestFolderTextBox.Location = new System.Drawing.Point(160, 66);
            this.TestFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TestFolderTextBox.Name = "TestFolderTextBox";
            this.TestFolderTextBox.Size = new System.Drawing.Size(165, 20);
            this.TestFolderTextBox.TabIndex = 0;
            // 
            // TestFolderLabel
            // 
            this.TestFolderLabel.AutoSize = true;
            this.TestFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestFolderLabel.Location = new System.Drawing.Point(11, 70);
            this.TestFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TestFolderLabel.Name = "TestFolderLabel";
            this.TestFolderLabel.Size = new System.Drawing.Size(108, 15);
            this.TestFolderLabel.TabIndex = 1;
            this.TestFolderLabel.Text = "Папка с тестами:";
            // 
            // PortLabelTextBox
            // 
            this.PortLabelTextBox.Location = new System.Drawing.Point(160, 143);
            this.PortLabelTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PortLabelTextBox.Name = "PortLabelTextBox";
            this.PortLabelTextBox.Size = new System.Drawing.Size(51, 20);
            this.PortLabelTextBox.TabIndex = 2;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PortLabel.Location = new System.Drawing.Point(11, 148);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(40, 15);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "Порт:";
            // 
            // SaveConfigButton
            // 
            this.SaveConfigButton.Location = new System.Drawing.Point(109, 220);
            this.SaveConfigButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveConfigButton.Name = "SaveConfigButton";
            this.SaveConfigButton.Size = new System.Drawing.Size(140, 31);
            this.SaveConfigButton.TabIndex = 4;
            this.SaveConfigButton.Text = "Сохранить";
            this.SaveConfigButton.UseVisualStyleBackColor = true;
            this.SaveConfigButton.Click += new System.EventHandler(this.SaveConfigButton_Click);
            // 
            // IpTextBox
            // 
            this.IpTextBox.Location = new System.Drawing.Point(160, 109);
            this.IpTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(165, 20);
            this.IpTextBox.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // IpLabel
            // 
            this.IpLabel.AutoSize = true;
            this.IpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IpLabel.Location = new System.Drawing.Point(11, 114);
            this.IpLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IpLabel.Name = "IpLabel";
            this.IpLabel.Size = new System.Drawing.Size(58, 15);
            this.IpLabel.TabIndex = 7;
            this.IpLabel.Text = "IP Адрес:";
            // 
            // ResultFolderLabel
            // 
            this.ResultFolderLabel.AutoSize = true;
            this.ResultFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultFolderLabel.Location = new System.Drawing.Point(11, 34);
            this.ResultFolderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultFolderLabel.Name = "ResultFolderLabel";
            this.ResultFolderLabel.Size = new System.Drawing.Size(141, 15);
            this.ResultFolderLabel.TabIndex = 9;
            this.ResultFolderLabel.Text = "Папка с результатами:";
            // 
            // ResultFolderTextBox
            // 
            this.ResultFolderTextBox.Location = new System.Drawing.Point(160, 30);
            this.ResultFolderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultFolderTextBox.Name = "ResultFolderTextBox";
            this.ResultFolderTextBox.Size = new System.Drawing.Size(165, 20);
            this.ResultFolderTextBox.TabIndex = 8;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 262);
            this.Controls.Add(this.ResultFolderLabel);
            this.Controls.Add(this.ResultFolderTextBox);
            this.Controls.Add(this.IpLabel);
            this.Controls.Add(this.IpTextBox);
            this.Controls.Add(this.SaveConfigButton);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.PortLabelTextBox);
            this.Controls.Add(this.TestFolderLabel);
            this.Controls.Add(this.TestFolderTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SettingForm";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TestFolderTextBox;
        private System.Windows.Forms.Label TestFolderLabel;
        private System.Windows.Forms.TextBox PortLabelTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Button SaveConfigButton;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label IpLabel;
        private System.Windows.Forms.Label ResultFolderLabel;
        private System.Windows.Forms.TextBox ResultFolderTextBox;
    }
}