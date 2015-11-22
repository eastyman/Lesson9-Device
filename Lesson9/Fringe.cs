using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class Fringe:Device
    {
        private int beerCount;
        public Fringe(int count)
        {
            beerCount = count;
        }
        public override void ViewState()
        {
            Console.WriteLine("Состояние холодильника:" + state);
            Console.WriteLine("Количество пива:" + beerCount);
        }
    }
}
