using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        static void Main()
        {
            RemoteImplementor condition = new Condition();
            RemoteT remote = new RemoteT(condition);

            remote.On();
            remote.PowerPlus();
            remote.ModeNext();
            remote.Save(1);
            remote.Load(1);
            remote.Off();
        }
    }
}
