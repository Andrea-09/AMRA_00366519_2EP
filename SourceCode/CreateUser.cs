using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCode
{
    public partial class CreateUser : UserControl
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    if (radioButton1.Checked)
                    {
                        ConnectionBD.ExecuteNonQuery($"INSERT INTO APPUSER (fullname, username, password, userType) " +
                                                     $"VALUES ('{textBox1.Text}', " +
                                                     $"'{textBox2.Text}', '{textBox3.Text}' ,'{false}')");

                        MessageBox.Show("Se ha registrado un usuario!");

                    }
                    else
                    {
                        ConnectionBD.ExecuteNonQuery($"INSERT INTO APPUSAER (fullname, name, password, userType) " +
                                                     $"VALUES ('{textBox1.Text}', " +
                                                     $"'{textBox2.Text}', '{textBox3.Text}' ,'{true}')");

                    }

                    MessageBox.Show("Se ha registrado un usuario!");

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error!");
                }
            }

        }
    }
}
