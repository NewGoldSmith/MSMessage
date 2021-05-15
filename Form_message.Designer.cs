
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
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_pos_X_number = new System.Windows.Forms.Label();
            this.label_pos_Y_number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_info_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // IDOK
            // 
            this.IDOK.Location = new System.Drawing.Point(73, 104);
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
            this.Label_message.Location = new System.Drawing.Point(124, 25);
            this.Label_message.Name = "Label_message";
            this.Label_message.Size = new System.Drawing.Size(82, 24);
            this.Label_message.TabIndex = 1;
            this.Label_message.Text = "label1";
            this.Label_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_info_icon
            // 
            this.pictureBox_info_icon.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_info_icon.Name = "pictureBox_info_icon";
            this.pictureBox_info_icon.Size = new System.Drawing.Size(59, 62);
            this.pictureBox_info_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_info_icon.TabIndex = 2;
            this.pictureBox_info_icon.TabStop = false;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(299, 212);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(42, 38);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "設";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_config_Click);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Location = new System.Drawing.Point(27, 180);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(19, 19);
            this.label_X.TabIndex = 4;
            this.label_X.Text = "X";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Location = new System.Drawing.Point(27, 212);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(19, 19);
            this.label_Y.TabIndex = 5;
            this.label_Y.Text = "Y";
            // 
            // label_pos_X_number
            // 
            this.label_pos_X_number.AutoSize = true;
            this.label_pos_X_number.Location = new System.Drawing.Point(62, 180);
            this.label_pos_X_number.Name = "label_pos_X_number";
            this.label_pos_X_number.Size = new System.Drawing.Size(19, 19);
            this.label_pos_X_number.TabIndex = 6;
            this.label_pos_X_number.Text = "0";
            // 
            // label_pos_Y_number
            // 
            this.label_pos_Y_number.AutoSize = true;
            this.label_pos_Y_number.Location = new System.Drawing.Point(62, 212);
            this.label_pos_Y_number.Name = "label_pos_Y_number";
            this.label_pos_Y_number.Size = new System.Drawing.Size(19, 19);
            this.label_pos_Y_number.TabIndex = 7;
            this.label_pos_Y_number.Text = "0";
            // 
            // Form_message
            // 
            this.AcceptButton = this.IDOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(341, 252);
            this.Controls.Add(this.label_pos_Y_number);
            this.Controls.Add(this.label_pos_X_number);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
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
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_pos_X_number;
        private System.Windows.Forms.Label label_pos_Y_number;
    }
}