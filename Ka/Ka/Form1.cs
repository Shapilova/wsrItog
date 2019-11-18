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

namespace Ka
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=172.20.10.8:1433;Initial Catalog=Speed;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into [dbo].[User] (name) values ('" + textBox1.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
