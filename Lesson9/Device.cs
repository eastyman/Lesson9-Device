using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class Device:ISwitchable
    {
        protected bool state;
        public void On()
        {
            state = true;
        }
        public void Off()
        {
            state = false;
        }
        public virtual void ViewState()
        {
            Console.WriteLine("Устройство" + state);
        }
    }
}
