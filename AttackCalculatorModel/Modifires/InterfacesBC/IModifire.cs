using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel
{
    interface IModifire
    {
        int getAttackModifire();
        int getDamageModifire();
        void setAttackModifire(int[] modifires);
        void setDamageModifire(int[] modifires);
    }
}
