using System;
using System.Drawing;
using System.Windows.Forms;

namespace MSMessage
{
    public partial class Form_save_confirm : Form
    {
        //セーブしてよいか確認ダイアログ。
        public Point indicate_pos;
        public Form_save_confirm()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public DialogResult ShowDialog(Point pos)
        {
            indicate_pos = pos;
            base.ShowDialog();
            return this.DialogResult;
        }

        protected override void OnShown(System.EventArgs e)
        {
            label_pos_X_number.Text = indicate_pos.X.ToString();
            label_pos_Y_number.Text = indicate_pos.Y.ToString();
        }

        private void IDOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void IDCHANCEL_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
