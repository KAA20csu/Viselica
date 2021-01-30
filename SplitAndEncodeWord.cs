using System;
using System.Collections.Generic;
using System.Text;

namespace Viselica
{
    class SplitAndEncodeWord
    {
        public void SplitAndEncodeSomeWord()
        {
            
            for (int i = 0; i<(AlllData.Words[AlllData.word]).Length - 1; i++)
            {
                AlllData.letter.Add((AlllData.Words[AlllData.word])[i].ToString());
                
            }
            AlllData.sumofletters = (AlllData.Words[AlllData.word]).Length - 1;
            
            for(int i = 0; i < AlllData.sumofletters; i++)
            {
                AlllData.Cherti.Add("_ ");
                Console.Write(AlllData.Cherti[i]);
                
            }



        }
    }
}
