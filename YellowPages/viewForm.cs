﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YellowPages
{
    public partial class viewForm : Form
    {
        public viewForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddForm secondform = new AddForm();
            secondform.Show();
        }
    }
}
