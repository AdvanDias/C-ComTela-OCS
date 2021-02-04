using System;
using System.Collections.Generic;
using System.Linq;
using Tesseract;

namespace Formulario
{
    class Ocstesseract
    {
        string pathimage = @"C:\Users\Advan\source\repos\OCR_Demo\OCR_Demo\2nota22.jpeg";
        string text = "";
        List<string> tabela2 = new List<string>();
        string mandar = "";


        public string sovai()
        {
            try
            {
                using (var engine = new TesseractEngine(@"./tessdata", "por", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(pathimage))
                    {
                        using (var page = engine.Process(img))
                        {
                            text = page.GetText();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            List<string> result = text.Replace(" ", ";").Split(';', '\n').ToList();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);

                if (result[i].Contains("789"))
                {
                    tabela2.Add("2-COD=" + result[i]);
                }
                if (result[i] == "DORALFLEX" || result[i] == "TORSILAX" || result[i] == "MASCARA")
                {
                    tabela2.Add("3-DESC=" + result[i]);
                }
                if (result[i] == "UND")
                {
                    tabela2.Add("1-UND=" + result[i - 1]);
                }

            }

            string combina = string.Join(",", tabela2).Replace(",", ";");


            return (combina);


        }
    }
}
