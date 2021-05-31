using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace carbuilding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string con = (@"Server =DESKTOP-O3UH2S9\SQLEXPRESS; Database = CarBuilding ;Integrated Security=true;");
        SqlCommand cmd;
        private void insert(string a, int b, string c)
        {
            SqlConnection sqlcon = new SqlConnection(con);

            cmd = new SqlCommand("inse1", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@CarName", SqlDbType.VarChar, 50).Value = a;
            cmd.Parameters.Add("@PlateNum", SqlDbType.Int).Value = b;
            cmd.Parameters.Add("@ParkingName", SqlDbType.VarChar, 50).Value = c;
            sqlcon.Open();
            cmd.ExecuteNonQuery();
          //  MessageBox.Show("hi");
            sqlcon.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text);
            this.Hide();
            Form3 a = new Form3();
            a.Show();
        }
    }
}
