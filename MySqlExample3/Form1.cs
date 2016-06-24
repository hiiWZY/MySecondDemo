using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlExample3;

namespace MySqlExample3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'worldDataSet.country' table. You can move, or remove it, as needed.
            //DataSet ds = new DataSet();
            

            this.countryTableAdapter.Fill(this.worldDataSet.country);
            //server=localhost;user id=root;password=wang943698.com;persistsecurityinfo=True;database=world
            MD5 md5 = new MD5();
            this.textBox1.Text=md5.MD5Encrypt("server=localhost;user id=root;password=wang943698.com;persistsecurityinfo=True;database=world", "wsqwzy22");
            
        }
    }
}
