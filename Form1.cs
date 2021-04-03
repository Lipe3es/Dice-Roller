using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste
{
    public partial class Rolador_de_Dados : Form
    {
        public Rolador_de_Dados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_maior.Text == "")
            {
                MessageBox.Show("Digite o número de lados do dado.");
                txt_maior.Focus();
            }
            else
            {

                Random aleatorio = new Random();
                int numero = 1;
                int final = Convert.ToInt32(txt_maior.Text);
                int limite = 1;

                string Resultado = "";

                for (numero = 0; numero <= limite - 1; numero++)
                {

                    Resultado = Resultado + " " + aleatorio.Next(numero, final + 1);
                    lbl_r1.Text = Resultado;

                }

                if (checkBox1.Checked == true)
                {

                    decimal pericia = decimal.Parse(txt_pericia.Text);
                    decimal dado = decimal.Parse(lbl_r1.Text);

                    decimal regular = pericia / 2;
                    decimal bom = pericia / 4;

                    regular = Math.Round(regular, 1);
                    bom = Math.Round(bom, 1);
                    bom = Math.Round(bom, 1);

                    if (dado > pericia)
                    {

                        lbl_r5.Text = "-------------------";

                    }

                    else if (dado >= regular)
                    {

                        lbl_r5.Text = "Você tirou regular";

                    }
                    else if (dado >= bom)
                    {

                        lbl_r5.Text = "Você tirou bom";

                    }
                    else
                    {

                        lbl_r5.Text = "Você tirou extremo";

                    }


                    if (dado > pericia)
                    {

                        lbl_r4.Text = "Você falhou no teste";

                    }
                    else
                    {
                        lbl_r4.Text = "Você passou no teste";


                    }

                }
               

                txt_maior.Clear();
                txt_pericia.Clear();
                txt_maior.Focus();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_menor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_maior_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_maior_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_pericia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pericia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Rolador_de_Dados_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 100, 100, 100);

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

           
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            txt_pericia.ReadOnly = false;

            if(checkBox1.Checked == false)
            {
                txt_pericia.ReadOnly = true;
                lbl_r4.Text = "";
                lbl_r5.Text = "";
            }

        }
    }
}
