using System;
using System.Collections.Generic;
using System.Text;

namespace Viselica
{
    class Game
    {
        public void GuessWord()
        {
            do
            {
                Console.WriteLine(" ");
                
                AlllData.guessedletter = Console.ReadLine();
                
                if ((AlllData.Words[AlllData.word]).Contains(AlllData.guessedletter))
                {
                    Console.Clear();
                    for (int i = 0; i < AlllData.sumofletters; i++)
                    {
                        AlllData.Cherti.Add("_ ");
                        AlllData.koordofletter = (AlllData.letter.IndexOf(AlllData.guessedletter));
                        AlllData.Cherti[AlllData.koordofletter] = AlllData.letter[AlllData.koordofletter];
                        Console.Write(AlllData.Cherti[i]);
                        
                    }
                    Console.SetCursorPosition(75, 0);
                    Console.Write("Ваше количество попыток:"+AlllData.count);
                    /*AlllData.koordofletter = (AlllData.letter.IndexOf(AlllData.guessedletter));
                    AlllData.Cherti[AlllData.koordofletter] = AlllData.letter[AlllData.koordofletter];*/

                }
                else
                {
                    
                    Console.SetCursorPosition(75, 0);

                    Console.WriteLine("Ваше количество попыток:" + AlllData.count--);
                }
                
            } while (AlllData.count != 0);
            if (AlllData.count == 0)
            {
                Console.Clear();
                Console.WriteLine("Вы проиграли!");
                Console.ReadKey();
            }
        }
    }
}
