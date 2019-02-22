using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel.Stats
{
    //этот класс формирует диктионари, содержащий информацию о состоянии базовых переменных и дает доступ к ней для 
    public class StatBlock
    {
        #region Initialize variables
        //Объявление и инициализация диктионари и базовых переменных
        private Dictionary<string, int> StatBlockList = new Dictionary<string, int>();
        private IStat strength = new AbilityStat(StatNames.str.ToString());
        private IStat dexterity = new AbilityStat(StatNames.dex.ToString());
        private IStat constitution = new AbilityStat(StatNames.con.ToString());
        private IStat intellegence = new AbilityStat(StatNames.inte.ToString());
        private IStat wisdom = new AbilityStat(StatNames.wis.ToString());
        private IStat charisma = new AbilityStat(StatNames.cha.ToString());
        private IStat characterLevel = new AbilityStat(StatNames.clvl.ToString());
        private IStat baseAttackBonus = new AbilityStat(StatNames.bab.ToString());
        private IStat variableAttackModifire = new VariableStat(StatNames.vam.ToString());
        private IStat variableDamageModifire = new VariableStat(StatNames.vdm.ToString());
        #endregion

        //метод должен устанавливать значения в диктионари, которые передаются из ВМ
        //!допилить!
        private void setStatsValues()
        {
            throw new NotImplementedException();
        }

        //метод добавляет экземпляры базовых значений в диктионари
        private void setStatBlock()
        {
            StatBlockList.Add(strength.Name, strength.Value);
            StatBlockList.Add(dexterity.Name, dexterity.Value);
            StatBlockList.Add(constitution.Name, constitution.Value);
            StatBlockList.Add(intellegence.Name, intellegence.Value);
            StatBlockList.Add(wisdom.Name, wisdom.Value);
            StatBlockList.Add(charisma.Name, charisma.Value);
            StatBlockList.Add(characterLevel.Name, characterLevel.Value);
            StatBlockList.Add(baseAttackBonus.Name, baseAttackBonus.Value);
            StatBlockList.Add(variableAttackModifire.Name, variableAttackModifire.Value);
            StatBlockList.Add(variableDamageModifire.Name, variableDamageModifire.Value);
        }

        //переделать для случаев, если передается некорректное имя.
        public int getStatValue(string name)
        {            
            if (StatBlockList.ContainsKey(name))
            {                
                return StatBlockList[name];
            }
            return 0;
        }

        //метод позволяет менять другим методам в рамках сборки значение базовой переменной
        //?подумать над необходимостью?
        internal void changeStatValue(string name, int newValue)
        {
            StatBlockList[name] = newValue;
        }
    }
}
