using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace MSMessage
{
    public partial class Form_message : Form
    {
        public string info_message;
        public Point screen_position;
        protected Point prev_mouse_point;

        protected override void OnShown(System.EventArgs e)
        {
            Screen screen;
            string str_X, str_Y;
            Point screen_point;

            Assembly myAssembly = Assembly.GetEntryAssembly();
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string filepath = path + "MSMessage.xml";
            if (File.Exists(filepath) == true)
            {
                XDocument xDocument = XDocument.Load(filepath);
                XElement xElement = xDocument.Element("config");
                str_X = xElement.Element("X").Value;
                str_Y = xElement.Element("Y").Value;
                screen_point = new Point(Convert.ToInt32(str_X), Convert.ToInt32(str_Y));
            }
            else
            {
                screen_point = this.Location;
            }
            //ダイアログがモニターの範囲にあるか確認。なければ、近いモニターの真ん中に表示。
            screen = Screen.FromPoint(screen_point);
            if (!screen.Bounds.Contains(screen_point))
            {
                Rectangle rect_screen, rect_this;
                rect_this = this.Bounds;
                rect_screen = screen.Bounds;
                rect_screen.X += (rect_screen.Size.Width / 2) - (rect_this.Size.Width / 2);
                rect_screen.Y += (rect_screen.Size.Height / 2) - (rect_this.Size.Height / 2);
                this.Location = rect_screen.Location;

            }
            else
            {
                this.Location = screen_point;
            }

            label_pos_X_number.Text = this.Location.X.ToString();
            label_pos_Y_number.Text = this.Location.Y.ToString();

            Label_message.Text = info_message;
            pictureBox_info_icon.Image = SystemIcons.Exclamation.ToBitmap();
            SystemSounds.Exclamation.Play();
        }

        public Form_message()
        {
            InitializeComponent();
            info_message = "default";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void IDOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs mouseEvent)
        {
            this.Capture = true;
            prev_mouse_point = mouseEvent.Location;

        }

        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs mouseEvent)
        {
            this.Capture = false;
        }

        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs mouseEvent)
        {
            if (this.Capture == true)
            {
                Point form_pt;
                form_pt = this.Location;
                form_pt.Offset((mouseEvent.X - prev_mouse_point.X), (mouseEvent.Y - prev_mouse_point.Y));
                this.Location = form_pt;
            }
        }

        protected override void OnMove(System.EventArgs eventArgs)
        {
            label_pos_X_number.Text = string.Format("{0:d}", this.Location.X);
            label_pos_Y_number.Text = string.Format("{0:d}", this.Location.Y);

        }

        private void button_config_Click(object sender, EventArgs e)
        {
            Form_save_confirm form_Save_Confirm = new Form_save_confirm() { TopMost = true, };

            DialogResult result = form_Save_Confirm.ShowDialog(this.Location);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            Assembly myAssembly = Assembly.GetEntryAssembly();
            string path = System.AppDomain.CurrentDomain.BaseDirectory;
            string filepath = path + "MSMessage.xml";

            XmlWriterSettings xml_witer_settings = new XmlWriterSettings();
            xml_witer_settings.Indent = true;

            XmlWriter writer = XmlWriter.Create(filepath, xml_witer_settings);
            writer.WriteStartElement("config");
            writer.WriteElementString("X", this.Location.X.ToString());
            writer.WriteElementString("Y", this.Location.Y.ToString());
            writer.WriteEndElement();
            writer.Close();

        }
    }
}
