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
    public partial class ModDir : UserControl
    {
        public ModDir()
        {
            InitializeComponent();
        }

        private void ModDir_Load(object sender, EventArgs e)
        {
            PoblarControles();

        }

        private void PoblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idAddress";
            comboBox1.DisplayMember = "address";
            comboBox1.DataSource = AddressDAO.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacio");
            }
            else
            {
                try
                {
                    ConnectionBD.ExecuteNonQuery($"UPDATE ADDRESS SET address = '{textBox1.Text}' " +
                        $"WHERE idAddress = {comboBox1.SelectedValue}");

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un erros");
                }
            }
        }
    }
}
