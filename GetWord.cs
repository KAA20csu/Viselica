using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Viselica
{
    class GetWord
    {
        public void GettingWord()
        {
            string text = (File.ReadAllText("C:/Dictionary.txt"));
            AlllData.Words.AddRange((text).Split("\n"));

            Random rnd = new Random();
            AlllData.word = rnd.Next(0, AlllData.Words.Count);
            AlllData.Words.Remove(AlllData.Words[AlllData.word]);
            /*Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");

            Console.WriteLine(AlllData.Words[AlllData.word]);*/
            
            
        }
    }
}
