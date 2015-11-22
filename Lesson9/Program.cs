using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {
            TVSet lg = new TVSet(10);
            lg.ViewState();
            Fringe samsung = new Fringe(20);
            samsung.ViewState();
            ISwitchable device = null;

            Console.WriteLine("0 - телевизор, 1 - холодильник");
            char key = Console.ReadKey().KeyChar;
            switch (key)
            {
                case '0':
                    Console.WriteLine("Выбран телевизор");
                    device = lg;
                    break;
                case '1':
                    Console.WriteLine("Выбран холодильник");
                    device = samsung;
                    break;
                default:
                    Console.WriteLine("Введите 0 или 1");
                    break;
            }

           // Console.Clear();
            Console.WriteLine("0 - выключить, 1 - включить");
            char k = Console.ReadKey().KeyChar;
            if (k != 0 || k != 1)
            {
                Console.WriteLine("Введите 0 или 1");
            }


            ISwitchMethod(device, k);

        }

        static void ISwitchMethod(ISwitchable dev, int x)
        {
            if (x == 0)
            {
                dev.Off();
                dev.ViewState();
            }
            else
            {
                dev.On();
                dev.ViewState();
            }
        }
    }
}
