
namespace MSMessage
{
    partial class Form_message
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
            this.IDOK = new System.Windows.Forms.Button();
            this.Label_message = new System.Windows.Forms.Label();
            this.pictureBox_info_icon = new System.Windows.Forms.PictureBox();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // IDOK
            // 
            this.IDOK.Location = new System.Drawing.Point(160, 165);
            this.IDOK.Name = "IDOK";
            this.IDOK.Size = new System.Drawing.Size(169, 53);
            this.IDOK.TabIndex = 0;
            this.IDOK.Text = "OK";
            this.IDOK.UseVisualStyleBackColor = true;
            this.IDOK.Click += new System.EventHandler(this.IDOK_Click);
            // 
            // Label_message
            // 
            this.Label_message.AutoSize = true;
            this.Label_message.Font = new System.Drawing.Font("ＭＳ ゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_message.Location = new System.Drawing.Point(12, 75);
            this.Label_message.Name = "Label_message";
            this.Label_message.Size = new System.Drawing.Size(82, 24);
            this.Label_message.TabIndex = 1;
            this.Label_message.Text = "label1";
            this.Label_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_info_icon
            // 
            this.pictureBox_info_icon.Location = new System.Drawing.Point(12, 138);
            this.pictureBox_info_icon.Name = "pictureBox_info_icon";
            this.pictureBox_info_icon.Size = new System.Drawing.Size(82, 80);
            this.pictureBox_info_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_info_icon.TabIndex = 2;
            this.pictureBox_info_icon.TabStop = false;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(160, 1);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(169, 38);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "表示位置を保存";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Form_message
            // 
            this.AcceptButton = this.IDOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.pictureBox_info_icon);
            this.Controls.Add(this.Label_message);
            this.Controls.Add(this.IDOK);
            this.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form_message";
            this.Text = "MSMessage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button IDOK;
        private System.Windows.Forms.Label Label_message;
        private System.Windows.Forms.PictureBox pictureBox_info_icon;
        private System.Windows.Forms.Button button_save;
    }
}