using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Formulario
{

    public partial class Form1 : Form
    {

        int x = 0;
        int y = 0;
        int a = 1;
        int numero = 0;

        string[,] nomes = new string[5, 3];
        ArrayList arr = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* String txt;
             txt = tb_texto.Text;
             lb_text.Text = txt;
            */
            //OU

            //lb_text.Text = tb_Codigo.Text;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {


            if (nomes[x, y] == null)
            {
                lb_info.Text = "Não Encontrado";
            }
            else
            {
                for (int i = 0; i < nomes.Length; i++)
                {

                    var guaradar = nomes[i, 0];
                    if (nomes[i, 0] != null)
                    {
                        if (tb_Codigo.Text == guaradar)
                        {
                            tb_Produto.Text = nomes[i, 1];
                            tb_Qntd.Text = nomes[i, 2];
                            lb_info.Text = "Produto Encontrado!";
                            break;
                        }
                        else
                        {
                            lb_info.Text = "Não Encontrado";
                        }
                    }
                    else
                    {
                        lb_info.Text = "Não Encontrado";
                        tb_Produto.Text = "";
                        tb_Qntd.Text = "";
                        break;
                    }

                }
            }

            /*
                        if (arr.Count == 0)
                        {
                            lb_info.Text = "Não Encontrado";

                        }
                        else {
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (tb_Codigo.Text == arr[i].ToString())
                                {
                                    lb_info.Text = tb_Codigo.Text;
                                    break;
                                }
                                else
                                {
                                    lb_info.Text = "Não Encontrado";
                                }
                            }
                        }
            */

        }

        private void btn_Cadastra_Click(object sender, EventArgs e)
        {
            if (nomes[x, y] == null)
            {
                nomes[0, 0] = tb_Codigo.Text;
                nomes[0, 1] = tb_Produto.Text;
                nomes[0, 2] = tb_Qntd.Text;

                tb_Codigo.Text = "";
                tb_Produto.Text = "";
                tb_Qntd.Text = "";

                lb_info.Text = "Casastrado com Sucesso!";
            }
            else
            {
                nomes[a, 0] = tb_Codigo.Text;
                nomes[a, 1] = tb_Produto.Text;
                nomes[a, 2] = tb_Qntd.Text;

                tb_Codigo.Text = "";
                tb_Produto.Text = "";
                tb_Qntd.Text = "";

                lb_info.Text = "Casastrado com Sucesso!";
                a++;
            }




        }



        private void btn_OCS_Click(object sender, EventArgs e)
        {
            Ocstesseract meu = new Ocstesseract();

            tb_OCSS.Text = meu.sovai();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            List<string> result = tb_OCSS.Text.Split(';', '\n').ToList();

            if (result[numero].Contains("UND"))
            {
                var x = result[numero].IndexOf('-');
                tb_Qntd.Text = result[numero].Substring(x + 1);
            }
            else if (result[numero] == null)
            {
                tb_Qntd.Text = "Vazio";
            }



            if (result[numero].Contains("COD"))
            {
                var x = result[numero].IndexOf('-');
                tb_Codigo.Text = result[numero].Substring(x + 1);
            }
            else if (result[numero] == null)
            {
                tb_Codigo.Text = "Vazio";
            }


            if (result[numero].Contains("DESC"))
            {
                var x = result[numero].IndexOf('-');
                tb_Produto.Text = result[numero].Substring(x + 1);
            }
            else if (result[numero] == null)
            {
                tb_Produto.Text = "Vazio";
            }

            if (tb_Codigo.Text != "" && tb_Produto.Text != "" && tb_Qntd.Text != "")
            {
                lb_testando.Text = "ASKJDGKJASDHKJASHasdasdasdasdasdDFKJASHFKJSDHKJFHSDK";
            }
            numero++;

        }
    }
}
