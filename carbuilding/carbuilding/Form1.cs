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
    public partial class Form1 : Form
    {

        string con = (@"Server =DESKTOP-O3UH2S9\SQLEXPRESS; Database = CarBuilding ;Integrated Security=true;");
        SqlCommand cmd;

        private void insert(string a,int b,string c,string d)
        {
            SqlConnection sqlcon = new SqlConnection(con);

            cmd = new SqlCommand("inse", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BuildingName", SqlDbType.VarChar, 50).Value = a;
            cmd.Parameters.Add("@FloorNum", SqlDbType.Int).Value = b;
            cmd.Parameters.Add("@ParkingName", SqlDbType.VarChar, 50).Value = c;
            cmd.Parameters.Add("@ParkingReservedOrNot", SqlDbType.VarChar, 50).Value = d;
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            sqlcon.Close();


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            insert(textBox1.Text ,int.Parse(textBox2.Text) ,textBox3.Text,textBox4.Text);
            this.Hide();
            Form2 a = new Form2();
            a.Show();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
