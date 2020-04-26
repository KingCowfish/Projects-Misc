using System;
using System.Collections.Generic;
using System.Text;
using static AdvancedConcepts.Program;

namespace AdvancedConcepts
{
    class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("paying principal.");
        }
    }
}
