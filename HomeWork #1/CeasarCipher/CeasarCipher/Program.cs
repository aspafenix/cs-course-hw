using System;

namespace CeasarCipher
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.WriteLine("Input text");
            var text = Console.ReadLine();
            
            Console.WriteLine("Input offset!");
            var offset = Console.ReadLine();

            Ceasar.Data.CeasarCipher ceasar = new Ceasar.Data.CeasarCipher(Convert.ToInt32(offset));
            var encrypted = ceasar.Encrypt(text);
            Console.WriteLine(encrypted);
            Console.ReadKey();
        }
    }
}
