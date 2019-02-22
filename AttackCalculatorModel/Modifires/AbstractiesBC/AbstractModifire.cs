using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel
{
    public class AbstractModifire : IModifire
    {
        private int _attackModifire;
        

        virtual public int getAttackModifire()
        {
            return _attackModifire;
        }

        virtual public void setAttackModifire(int[] modifires)
        {
            int temp = 0;
            if (modifires.Length != 0)
            {
                for (int i = 0; i<modifires.Length; i++)
                {
                    temp += modifires[i];
                }
            }

            this._attackModifire = temp;
        }

        private int _damageModifire;

        virtual public void setDamageModifire(int[] modifires)
        {
            int temp = 0;
            if (modifires.Length != 0)
            {
                for (int i = 0; i < modifires.Length; i++)
                {
                    temp += modifires[i];
                }
            }
            this._damageModifire = temp;
        }

        virtual public int getDamageModifire()
        {
            return _damageModifire;
        }
    }
}
