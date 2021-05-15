
namespace MSMessage
{
    partial class Form_save_confirm
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
            this.IDCHANCEL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_pos_Y_number = new System.Windows.Forms.Label();
            this.label_pos_X_number = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDOK
            // 
            this.IDOK.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDOK.Location = new System.Drawing.Point(32, 137);
            this.IDOK.Name = "IDOK";
            this.IDOK.Size = new System.Drawing.Size(109, 51);
            this.IDOK.TabIndex = 0;
            this.IDOK.Text = "OK";
            this.IDOK.UseVisualStyleBackColor = true;
            this.IDOK.Click += new System.EventHandler(this.IDOK_Click);
            // 
            // IDCHANCEL
            // 
            this.IDCHANCEL.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IDCHANCEL.Location = new System.Drawing.Point(200, 137);
            this.IDCHANCEL.Name = "IDCHANCEL";
            this.IDCHANCEL.Size = new System.Drawing.Size(109, 51);
            this.IDCHANCEL.TabIndex = 1;
            this.IDCHANCEL.Text = "Cancel";
            this.IDCHANCEL.UseVisualStyleBackColor = true;
            this.IDCHANCEL.Click += new System.EventHandler(this.IDCHANCEL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "ダイアログの位置を保存します。\r\nよろしいですか？";
            // 
            // label_pos_Y_number
            // 
            this.label_pos_Y_number.AutoSize = true;
            this.label_pos_Y_number.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pos_Y_number.Location = new System.Drawing.Point(155, 101);
            this.label_pos_Y_number.Name = "label_pos_Y_number";
            this.label_pos_Y_number.Size = new System.Drawing.Size(21, 21);
            this.label_pos_Y_number.TabIndex = 11;
            this.label_pos_Y_number.Text = "0";
            this.label_pos_Y_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pos_X_number
            // 
            this.label_pos_X_number.AutoSize = true;
            this.label_pos_X_number.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_pos_X_number.Location = new System.Drawing.Point(155, 69);
            this.label_pos_X_number.Name = "label_pos_X_number";
            this.label_pos_X_number.Size = new System.Drawing.Size(21, 21);
            this.label_pos_X_number.TabIndex = 10;
            this.label_pos_X_number.Text = "0";
            this.label_pos_X_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Y.Location = new System.Drawing.Point(120, 101);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(21, 21);
            this.label_Y.TabIndex = 9;
            this.label_Y.Text = "Y";
            this.label_Y.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Font = new System.Drawing.Font("ＭＳ ゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_X.Location = new System.Drawing.Point(120, 69);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(21, 21);
            this.label_X.TabIndex = 8;
            this.label_X.Text = "X";
            this.label_X.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_save_confirm
            // 
            this.AcceptButton = this.IDOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.IDCHANCEL;
            this.ClientSize = new System.Drawing.Size(352, 223);
            this.Controls.Add(this.label_pos_Y_number);
            this.Controls.Add(this.label_pos_X_number);
            this.Controls.Add(this.label_Y);
            this.Controls.Add(this.label_X);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDCHANCEL);
            this.Controls.Add(this.IDOK);
            this.Name = "Form_save_confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDOK;
        private System.Windows.Forms.Button IDCHANCEL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_pos_Y_number;
        private System.Windows.Forms.Label label_pos_X_number;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_X;
    }
}