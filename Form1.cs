using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace taistra
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }  

        private Color SelectColors()
        {
            int index = random.Next(Colors.ColorList.Count);
            while (tempIndex==index)
            {
                random.Next(Colors.ColorList.Count);

            }
            tempIndex = index;
            string color = Colors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit application","You want to exit from application ;", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
                else if (DialogResult == DialogResult.No)
            {
                //nothing
            }
        }

        private void planbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void appbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void feedbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feeder form = new Feeder();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Need water!";
            popup.ContentText = "Thank ";
            popup.Popup();
        }
    }
}
