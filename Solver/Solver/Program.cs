using System;
using System.Globalization;
using System.Text;
using System.Threading;
namespace Solver
{
    internal class Program
    {
        private static Random random = new Random();
        private static void Main(string[] args)
        {
            //var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            //var stringChars = 'X';
            //var random = new Random();
            string userName = "Personal";
            string result="00000000";
            //var stringChars = new char[8];
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            //StringBuilder sb = new StringBuilder(userName);
            //userName = "Personaq";//"hackdef{";//new String(stringChars);//"Gangnam";//Environment.UserName;
            //Console.WriteLine("Bienvenido {0}. \nPresiona la combinacion correcta para acceder...", (object)userName);
               // while(!(result.Contains("hackdef{")))
            //{
              //  stringChars = chars[random.Next(chars.Length)];
                
                //sb[7] = stringChars;
                //userName = sb.ToString();
                Console.WriteLine(new Flag(userName).print()); //result = new Flag(userName).print();
                    result = new Flag(userName).print();//Console.WriteLine(result);
                    if (result.Contains("hackdef{"))
                    {
                        Console.WriteLine("Respuesta!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!: {0}", result);
                        //Console.WriteLine("Caracter: {0}", stringChars);
                    }
            //}
            
            Console.ReadKey();
        }
    }
}
