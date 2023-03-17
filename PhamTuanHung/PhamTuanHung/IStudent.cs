using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public interface IStudent
    {
        int StudID { get; set; }
        int StudAge { get; set; }
        string StudName { get; set; }
        string StudGender { get; set; }
        string StudClass { get; set; }
        float StudAvgMark { get; }
        void Print();
    }
}
