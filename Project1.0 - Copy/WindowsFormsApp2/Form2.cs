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
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-0EH2F7K;Initial Catalog=Project;Integrated Security=True;");




        private void button2_Click(object sender, EventArgs e)
        {
            String username, password;

             username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                String Querry = "Select * From Login Where username = '" + txt_username.Text+"' And password_ = '"+txt_password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(Querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count  > 0 )
                {
                    username = txt_username.Text;
                    password = txt_password.Text;

                    Form3 frm3 = new Form3();
                    frm3.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();
                }



            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }





           


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
