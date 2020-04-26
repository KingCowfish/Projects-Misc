using System;
using System.Collections.Generic;
using System.Text;
using static AdvancedConcepts.Program;

namespace AdvancedConcepts
{
    class Teacher : Member, IPayee
    {
        public string Subject { get; set; }

        public void Pay()
        {
            Console.WriteLine("paying teacher.");
        }
    }

}
