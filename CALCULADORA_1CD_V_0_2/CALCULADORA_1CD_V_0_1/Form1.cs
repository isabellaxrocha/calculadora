using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
-dividir por zero x - ok
-números com letras x - ok
-espaços em branco x 
 */

namespace CALCULADORA_1CD_V_0_1
{
    public partial class Form1 : Form
    {
        String n1, n2, operação, memória; //String é texto

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void bt_soma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operação = "soma";
            }
        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n2 = textBox1.Text;
                if (operação == "%")
                    textBox1.Text =
                        Convert.ToString(Convert.ToDouble(n1) * Convert.ToDouble(n2)/100);
                if (operação == "soma")
                    textBox1.Text =
                        Convert.ToString(Convert.ToDouble(n1) + Convert.ToDouble(n2));
                if (operação == "subtração")
                    textBox1.Text =
                        Convert.ToString(Convert.ToDouble(n1) - Convert.ToDouble(n2));
                if (operação == "multiplicação")
                    textBox1.Text =
                        Convert.ToString(Convert.ToDouble(n1) * Convert.ToDouble(n2));
                if (operação == "divisão")
                {
                    if (n2 != "0")
                    {
                        textBox1.Text = Convert.ToString(Convert.ToDouble(n1) / Convert.ToDouble(n2));
                    }
                    else
                        MessageBox.Show("Não dividir por zero!");
                }
            }
        }

        private void bt_subtração_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operação = "subtração";
            }
        }

        private void bt_multiplicação_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operação = "multiplicação";
            }
        }

        private void bt_divisão_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operação = "divisão";
            }
        }

        //AJUDA
        private void label1_Click(object sender, EventArgs e)
        {
            fm_Ajuda janelaDeAjuda = new fm_Ajuda();
            janelaDeAjuda.Show();
        }

        private void bt_CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operação = "";
            n1 = "";
            n2 = "";
        }

        private void bt_MS_Click(object sender, EventArgs e)
        {
            lb_M.Visible = true;
            memória = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_M.Visible = false;
        }

        private void bt_MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = memória;
        }

        private void bt_porcentagem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                n1 = textBox1.Text;
                textBox1.Text = "";
                operação = "%";
            }
        }

        private void bt_MC_Click(object sender, EventArgs e)
        {
            lb_M.Visible = false;
            memória = "";
        }

        private void bt_vírgula_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void bt_c_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
