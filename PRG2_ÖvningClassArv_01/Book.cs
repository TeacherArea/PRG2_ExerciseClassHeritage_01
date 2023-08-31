using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_ExerciseClassHeritage_01_solution
{
    internal class Book : Media
    {
        public int pages = 0;
        public override string ToString()
        {
            return title + ": " + pages + " sidor.";
        }
    }
}
