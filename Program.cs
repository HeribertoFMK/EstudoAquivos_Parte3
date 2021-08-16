
using System.IO;
using System;



namespace arquivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //? Primeiro exercico onde le so um linha.
            string path = @"C:\csharp\texto1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                using (fs = new FileStream(path, FileMode.Open))
                {
                    using (sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();//! Ler so a primeira linha
                        System.Console.WriteLine(line);
                    }
                }



            }
            catch (IOException e)
            {
                System.Console.WriteLine("Houve um Erro!");
                System.Console.WriteLine(e.Message);
            }




            //    ? segundo exercico onde se le a lista dentro do arquivo.
            string path1 = @"C:\csharp\texto1.txt";
            FileStream fs1 = null;
            StreamReader sr1 = null;

            try
            {
                using (fs1 = new FileStream(path1, FileMode.Open))
                {
                    using (sr1 = new StreamReader(fs1))
                    {
                        while (!sr1.EndOfStream)
                        {

                            string lines = sr1.ReadLine();
                            System.Console.WriteLine(lines);
                        }
                    }


                }





            }
            catch (IOException e)
            {
                System.Console.WriteLine("Houve um Erro!");
                System.Console.WriteLine(e.Message);
            }


            // //? terceiro exercico, mais simplificado em ler a lista dentro do arquivo.

            string path2 = @"C:\csharp\texto1.txt";
            StreamReader sr2 = null;

            try
            {
                using (sr2 = File.OpenText(path2))
                {
                    while (!sr2.EndOfStream)
                    {
                        string line = sr2.ReadLine();
                        System.Console.WriteLine(line);
                    }
                }

            }
            catch (IOException e)
            {
                System.Console.WriteLine("Houve um erro!");
                System.Console.WriteLine(e.Message);



            }
        }
    }
}




