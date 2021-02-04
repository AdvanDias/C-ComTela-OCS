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
        int limite = 3;

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
            TrataTexo trataTexo = new TrataTexo();
            var textotratado = trataTexo.TratandoOtexto(meu.sovai());
            tb_OCSS.Text = textotratado;
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            List<string> result = tb_OCSS.Text.Split(';', '\n').ToList();
            if (tb_OCSS.Text == "")
            {
                lb_info.Text = "NÃO HÁ REGISTROS NA TABELA";
            }
            else
            {
                for (int i = numero; i < limite; i++)
                {
                    if (limite > result.Count())
                    {
                        lb_info.Text = "NÃO HÁ MAIS REGISTROS A SEREM INCLUIDOS";
                        limite = result.Count();
                        break;
                    }
                    else
                    {
                        var item = result[i].IndexOf("-");
                        var condicao = result[i].Substring(0, item);
                        switch (condicao)
                        {
                            case "1":
                                var inicio1 = result[i].IndexOf("=");
                                var final1 = result[i].Substring(inicio1 + 1);
                                tb_Qntd.Text = final1;
                                break;
                            case "2":
                                var inicio2 = result[i].IndexOf("=");
                                var final2 = result[i].Substring(inicio2 + 1);
                                tb_Codigo.Text = final2;
                                break;
                            case "3":
                                var inicio3 = result[i].IndexOf("=");
                                var final3 = result[i].Substring(inicio3 + 1);
                                tb_Produto.Text = final3;
                                break;
                        }
                    }
                    lb_info.Text = "";
                }

                numero = numero + 3;
                limite = limite + 3;
                

            }
            
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {

        }
    }
}
