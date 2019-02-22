using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttackCalculatorModel.Stats
{
    /// <summary>
    /// этот класс формирует диктионари, содержащий информацию о состоянии базовых переменных и дает доступ к ней для 
    /// </summary>
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

        /// <summary>
        /// метод должен устанавливать значения в диктионари, которые передаются из ВМ
        /// </summary>
        //!запилить!
        private void setStatsValues()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// метод добавляет экземпляры базовых значений в диктионари
        /// </summary>
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

        /// <summary>
        /// Возвращает значение базового параметра
        /// </summary>
        /// <param name="name">Сокращенное имя базового параметра, соответствующего одному из значений StatNames</param>
        /// <returns>Возвращает значение базового параметра</returns>
        //переделать для случаев, если передается некорректное имя.
        public int getStatValue(string name)
        {            
            if (StatBlockList.ContainsKey(name))
            {                
                return StatBlockList[name];
            }
            return 0;
        }

        /// <summary>
        /// Метод позволяет менять другим методам в рамках сборки значение базовой переменной
        /// </summary>
        /// <param name="name">Сокращенное имя базового параметра, соответствующего одному из значений StatNames</param>
        /// <param name="newValue">Новое значение базового парметра</param>
        //?подумать над необходимостью?
        internal void changeStatValue(string name, int newValue)
        {
            StatBlockList[name] = newValue;
        }
    }
}
