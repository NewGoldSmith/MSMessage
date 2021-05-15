using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace MSMessage
{
    public partial class Form_message : Form
    {
        public string info_message;
        public Point sclean_position;
        public new DialogResult ShowDialog()
        {
            DialogResult rsult = base.ShowDialog();
            return rsult;
        }

        protected override void OnShown(System.EventArgs e)
        {
            if (!sclean_position.IsEmpty)
            {
                this.Location = sclean_position;
            }
            Label_message.Text = info_message;
            pictureBox_info_icon.Image = SystemIcons.Exclamation.ToBitmap();
            SystemSounds.Exclamation.Play();
        }

        public Form_message()
        {
            InitializeComponent();
            info_message = "default";

        }
        private void IDOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }
    }
}
