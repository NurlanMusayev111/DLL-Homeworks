using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace_DLL_abstraction
{
    internal class Eagle : Bird
    {
        public override void Sound()
        {
            Console.WriteLine("Eagle sound");
        }
    }
}
