﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST
{
    public partial class reportcs : Form
    {
        public reportcs()
        {
            InitializeComponent();
        }

        private void reportcs_Load(object sender, EventArgs e)
        {
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Products' table. You can move, or remove it, as needed.
            this.ProductsTableAdapter.Fill(this.DataSet1.Products,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
