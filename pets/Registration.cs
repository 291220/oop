using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
//using pets.Db;

namespace pets
{
    public partial class Registration : Form
    {
        private string _gender;

        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            male.Checked = true;
            female.Checked = false;
            _gender = "Male";
            LoadDefault();
        }

        private void LoadDefault()
        {
            var sql = "select idno,name,gender,address,contact from user order by id";
            var myData = Db.GetData(sql);
            if(myData!= null )
            {
                var bs = new BindingSource();
                bs.DataSource = myData;
                dataGridView1.DataSource = bs;
            }
            else
            {
                MessageBox.Show("No records found");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               if(string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text)|| string.IsNullOrEmpty(textBox2.Text)|| string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Kindly input all records");
                    textBox4.Focus();
                    return;

                }
                var test = Db.Execute("insert into user(idno,name,address,contact,gender) values" +
                    "('" + textBox2.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox1.Text + "','" + _gender + "')");
                if (test)
                {
                    MessageBox.Show("Values submitted successifuly");
                    LoadDefault();
                    textBox4.Text= textBox2.Text= textBox3.Text= textBox1.Text="";
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            _gender = "Male";
        }

        private void female_CheckedChanged(object sender, EventArgs e)
        {
            _gender = "Female";
        }
    }
}
