using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario
{
    class TrataTexo
    {
        public string nome1 = "1-UND=Vazio";
        public string nome2 = "2-COD=Vazio";
        public string nome3 = "3-DESC=Vazio";
        int n1 = 0;
        int n2 = 1;
        int n3 = 2;
        int x1 = 0;
        int x2 = 1;
        int x3 = 2;
        public int limit = 2;
        public int control = 0;
        public int control2 = 0;
        int guradei = 0;


        public string TratandoOtexto(string texto) 
        {
            List<string> tabela1 = texto.Split(';').ToList();
            List<string> tabela2 = new List<string> { "1-UND=Vazio", "2-COD=VAzio", "3-DESC=Vazio" };

            for (int i = 0; i < 10; i++)
            {
                for (int x = control; x <= limit; x++)
                {
                    if (x == n1)
                    {
                        if (x >= tabela1.Count())
                        {
                            guradei = tabela1.Count();
                            nome1 = "1-UND=Vazio";

                        }
                        else
                        {
                            nome1 = tabela1[x];
                        }

                    }
                    else if (x == n2)
                    {
                        if (x >= tabela1.Count())
                        {
                            guradei = tabela1.Count();
                            nome2 = "2-COD=Vazio";

                        }
                        else
                        {
                            nome2 = tabela1[x];
                        }

                    }
                    else if (x == n3)
                    {
                        if (x >= tabela1.Count())
                        {
                            guradei = tabela1.Count();
                            nome3 = "3-DESC=Vazio";

                        }
                        else
                        {
                            nome3 = tabela1[x];
                        }

                    }


                }
                control = control + 3;


                var pega1 = nome1.IndexOf("-");
                var pega2 = nome2.IndexOf("-");
                var pega3 = nome3.IndexOf("-");

                var joga1 = nome1.Substring(0, pega1);//2
                var joga2 = nome2.Substring(0, pega2);//3
                var joga3 = nome3.Substring(0, pega3);//1



                for (int y = control2; y < tabela2.Count; y++)
                {


                    if (joga1 == "1")
                    {
                        tabela2[x1] = nome1;
                        joga1 = "X";
                    }
                    else if (joga2 == "2")
                    {
                        tabela2[x2] = nome2;
                        joga2 = "X";
                    }
                    else if (joga3 == "3")
                    {
                        tabela2[x3] = nome3;
                        joga3 = "X";
                    }


                }
                control2 = control2 + 3;






                if (nome1.Contains("UND") && nome2.Contains("UND") && nome3.Contains("UND"))
                {
                    //1 1 1/
                    control = control - 2;
                    n1 = n1 - 2;
                    n2 = n2 - 2;
                    n3 = n3 - 2;
                }
                else if (nome1.Contains("UND") && nome2.Contains("UND") && nome3.Contains("DESC") && guradei == tabela1.Count())
                {
                    control = control - 2;
                    n1 = n1 - 2;
                    n2 = n2 - 2;
                    n3 = n3 - 2;
                    guradei = guradei - 1;
                }
                else if (nome1.Contains("UND") && nome2.Contains("UND") && nome3.Contains("DESC") && guradei < tabela1.Count())
                {
                    control = control - 1;
                    n1 = n1 - 1;
                    n2 = n2 - 1;
                    n3 = n3 - 1;
                }
                else if (nome1.Contains("COD") && nome2.Contains("DESC") && nome3.Contains("UND"))
                {
                    tabela2[x1] = "1-UND=Vazio";
                    tabela2[x2] = nome1;
                    tabela2[x3] = nome2;
                    control = control - 1;
                    n1 = n1 - 1;
                    n2 = n2 - 1;
                    n3 = n3 - 1;
                }
                else if (nome1.Contains("UND") && nome2.Contains("UND"))
                {
                    //1 1 x/
                    control = control - 1;
                }
                else if (nome1.Contains("UND") && nome3.Contains("UND"))
                {
                    // 1 x 1
                    control = control - 1;
                    n1 = n1 - 1;
                    n2 = n2 - 1;
                    n3 = n3 - 1;

                }
                else if (nome1.Contains("COD") && nome2.Contains("COD") && nome3.Contains("COD"))
                {
                    //1 2 x
                    var remover = tabela1[control - 1];
                    tabela1.Remove(remover);
                    control = control - 2;

                }
                else if (nome1.Contains("COD") && nome2.Contains("COD") && guradei < tabela1.Count())
                {
                    // 1 x 3
                    control = control - 1;
                }
                else if (nome1.Contains("COD") && nome2.Contains("DESC") && nome3.Contains("DESC"))
                {
                    tabela2[x2] = nome1;
                    tabela2[x3] = nome2;
                    n1 = n1 - 1;
                    n2 = n2 - 1;
                    n3 = n3 - 1;

                    control = control - 1;
                }
                else if (nome1.Contains("DESC") && nome2.Contains("DESC") && nome3.Contains("DESC"))
                {
                    // 3 3 3

                }
                else if (nome1.Contains("DESC") && guradei == tabela1.Count())
                {
                    var g = tabela2.Count();
                    tabela2[guradei] = "1-UND=Vazio";
                    tabela2[guradei + 1] = "2-COD=Vazio";
                    tabela2[g - 1] = nome1;
                }
                else if (nome1.Contains("UND") && nome2.Contains("COD") && nome3.Contains("COD"))
                {
                    control = control - 1;
                    n1 = n1 - 1;
                    n2 = n2 - 1;
                    n3 = n3 - 1;
                }
                else if (nome1.Contains("COD") && nome2.Contains("COD") && nome3.Contains("DESC") && guradei == tabela1.Count())
                {
                    tabela2[x1] = "1-UND=Vazio";
                    tabela2[x2] = nome1;
                    tabela2[x3] = nome3;
                }







                if (tabela1.Count() == guradei)
                {
                   
                    break;
                }
                else
                {
                    tabela2.Add("1-UND=Vazio");
                    tabela2.Add("2-COD=Vazio");
                    tabela2.Add("3-DESC=Vazio");
                    n1 = n1 + 3;
                    n2 = n2 + 3;
                    n3 = n3 + 3;
                    x1 = x1 + 3;
                    x2 = x2 + 3;
                    x3 = x3 + 3;
                    limit = limit + 3;
                }



            }

            var convertido = string.Join(";", tabela2);

            return convertido;
        }
    }
}
