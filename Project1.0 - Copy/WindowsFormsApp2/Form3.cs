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
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex--;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source=DESKTOP-0EH2F7K;Initial Catalog=Project;Integrated Security=True;";


            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();


            string Date_ = textBox12.Text;
            string Description_ = textBox4.Text;
            string AmountRs = textBox5.Text;



            String Query = "Insert into Incomes(AmountRs, Description_, date_) Values ('"+AmountRs+"', '"+Description_+"', '"+Date_+"')";



            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Record added successfully");



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex--;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=DESKTOP-0EH2F7K;Initial Catalog=Project;Integrated Security=True;";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();

            string Query = "Select Date_, Description_, AmountRs, Category From Incomes, IncomeCategories";
            
            SqlCommand cmd = new SqlCommand(Query, conn);

            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);

            incomeDataGridView.DataSource = table;


            conn.Close();






        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
    }
}
