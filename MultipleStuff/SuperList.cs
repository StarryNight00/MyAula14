using System;
using System.Collections.Generic;
using System.Text;

namespace MultipleStuff
{
    class SuperList : List<double>
    {

        public void GetMinMax(out double min, out double max)
        {
            Sort();
            min = this[0];
            max = this[Count - 1];
        }

    }
}
