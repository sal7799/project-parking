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
    public partial class Form3 : Form
    {
        string con = (@"Server =DESKTOP-O3UH2S9\SQLEXPRESS; Database = CarBuilding ;Integrated Security=true;");
        SqlCommand cmd;

        public void del(int a)
        {

            SqlConnection sqlcon = new SqlConnection(con);

            cmd = new SqlCommand("deleteB", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PlateNum", a);
            sqlcon.Open();
            cmd.ExecuteReader();        
            sqlcon.Close();


                }
        public void check(string a)
        {
            SqlConnection sqlcon = new SqlConnection(con);

            cmd = new SqlCommand("ser", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PlateNum", a);
            sqlcon.Open();
            SqlDataAdapter sqla = new SqlDataAdapter(cmd);
            DataSet fd = new DataSet();
            sqla.Fill(fd);
            sqlcon.Close();

            int count = fd.Tables[0].Rows.Count;
            if (count == 1)
            {
                MessageBox.Show("found" );
                if (MessageBox.Show("do you want to delete car?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                {
                    del(int.Parse(textBox1.Text));
                }
            }
            else
            {
                MessageBox.Show("no paarking");
                
                Form2 al = new Form2();
                al.Show();
            }

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 a = new Form1();
            a.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            check(textBox1.Text);
           
        }
    }
}
