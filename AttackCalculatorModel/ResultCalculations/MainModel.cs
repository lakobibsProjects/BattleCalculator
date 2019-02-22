using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel
{
    class MainModel
    {

    }

    class AttackCalculation : IGroundOperation
    {
        public void Calculate(int[] inputParametres, out int result)
        {
            result = 0;

            foreach (int i in inputParametres)
            result += i;                      
        }
    }
}
