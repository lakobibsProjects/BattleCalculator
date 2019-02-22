using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel
{
    class PowerAttackModifire : IModifire
    {
        int attackPAM;
        int dmgPAM;

        public int getAttackModifire()
        {
            return attackPAM;
        }

        public int getDamageModifire()
        {
            return dmgPAM;
        }

        public void setAttackModifire(int[] modifires)
        {
            int temp = 0;
            if (modifires.Length != 0)            
                temp = - (1 + modifires[0] / 4);            
            this.attackPAM = temp;
        }

        public void setDamageModifire(int[] modifires)
        {
            int temp = 0;
            if (modifires.Length != 0)            
                temp = 2 + 2 * (modifires[0] / 4);            
            this.dmgPAM = temp;
        }

    }
}
