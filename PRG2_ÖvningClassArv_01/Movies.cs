using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_ExerciseClassHeritage_01_solution
{
    internal class Movies : Sound
    {
        public string resolution = "";

        public override string ToString()
        {
            return base.ToString() + " " + resolution;
        }
    }
}
