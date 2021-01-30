 using System;

namespace Viselica
{
    class Program
    {
        static void Main(string[] args)
        {
            GetWord link = new GetWord();
            link.GettingWord();
            SplitAndEncodeWord link2 = new SplitAndEncodeWord();
            link2.SplitAndEncodeSomeWord();
            Count link3 = new Count();
            link3.CountTries();
            Game link4 = new Game();
            link4.GuessWord();
        }
    }
}
