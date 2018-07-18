using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-PTHVGCI;Initial Catalog=Stock1;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
               FROM[Stock1].[dbo].[Login] Where UserName = '"+ textBox1.Text +"' and Password = '"+ textBox2.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                STMain main = new STMain();
                main.Show();
            }
            else
            {
                MessageBox.Show("Password is incorreted");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
