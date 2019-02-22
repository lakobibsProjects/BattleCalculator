using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel.Stats
{
    //класс описывает основные свойства недетерминированных базовых переменных
    class VariableStat : IStat
    {
        #region Constants
        private const int minVariableValue = -15;
        private const int maxVariableValue = 150;
        #endregion

        #region Properties
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                this._value = value;
                if (value < minVariableValue)
                    this._value = minVariableValue;
                if (value > maxVariableValue)
                    this._value = maxVariableValue;
            }
        }

        private string name;
        public string Name { get { return Name; } set { Name = value; } }
        #endregion

        #region Constructors
        public VariableStat()
        {
            name = "";
            _value = 0;
        }

        public VariableStat(int value)
        {
            _value = value;
        }

        public VariableStat(string name)
        {
            this.name = name;
            _value = 0;
        }
        public VariableStat(string name, int value)
        {
            this.name = name;
            _value = value;
        }
        #endregion
    }
}
