using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace taistra
{
    public partial class Feeder : Form
    {
        public static Feeder instance;
        public Feeder()
        {
            InitializeComponent();
            instance = this;
            
        }

        private void Waterbtn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBarWater.Value = i;
                circularProgressBarWater.Update();
            }
            MessageBox.Show("Successful!");

        }
        

    private void Feeder_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 68;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;

            circularProgressBarWater.Value = 10;
            circularProgressBarWater.Minimum = 0;
            circularProgressBarWater.Maximum = 100;

            Random rnd = new Random();
            int not = rnd.Next(1, 4);
            random randm = new random();
            if (not==1)
               {
               
                randm.LabelText = "Ο σκύλος έχει πετάξει το φαγητό του!";
            }
            else if (not==2)
            {
                randm.LabelText = "Έφαγε το φαγητό του!";
            }
            else if (not==3)
            {
                randm.LabelText = "Ήπιε το νερό του !";
            }
            else if (not==4)
            {
                
                randm.LabelText = "Έριξε το φαγητό του !";
            }
            randm.Show();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("Do you want this amount;","Attention",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //nothing
            }
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(5);
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
                
            }
        }

    
        private void Previousbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
