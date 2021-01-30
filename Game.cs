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
                    AlllData.koordofletter = (AlllData.letter.IndexOf(AlllData.guessedletter));
                    AlllData.Cherti[AlllData.koordofletter] = AlllData.letter[AlllData.koordofletter];
             
                }
                else
                {
                    
                    Console.SetCursorPosition(75, 0);

                    Console.WriteLine(AlllData.count--);
                }
            } while (AlllData.count != 0);
            
        }
    }
}
