﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taistra
{
    public partial class random : Form
    {
        public random()
        {
            InitializeComponent();
        }

        private void random_Load(object sender, EventArgs e)
        {

        }
        public string LabelText
        {
            get
            {
                return this.labeltext.Text;
            }
            set
            {
                this.labeltext.Text = value;
            }
        }
    }
}
