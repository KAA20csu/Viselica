using System;
using System.Collections.Generic;
using System.Text;

namespace Viselica
{
    class Count
    {
        public void CountTries()
        {
            AlllData.count = AlllData.sumofletters;
            Console.SetCursorPosition(60, 0);
            Console.WriteLine("Ваши попытки:" + AlllData.count);
        }
    }
}
