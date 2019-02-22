using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Xceed.Wpf.Toolkit;

namespace PathfinderBattleCaclculatorC
{
    public class StatsVM
    {
        private void ButtonSpinner_Spin(object sender, SpinEventArgs e)
        {
            ButtonSpinner spinner = (ButtonSpinner)sender;
            TextBox txtBox = (TextBox)spinner.Content;

            int value = String.IsNullOrEmpty(txtBox.Text) ? 0 : Convert.ToInt32(txtBox.Text);
            if (e.Direction == SpinDirection.Increase)
                value++;
            else
                value--;
            txtBox.Text = value.ToString();
        }
        
        class StatModifire
        {
            string Name { get; }
            int Value { get; set; }
        }

        class StatsModifiersCollection : List<StatModifire>
        {
            public StatsModifiersCollection() { }
        }
    }
}
