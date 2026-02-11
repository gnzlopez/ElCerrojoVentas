using ElCerrojoPresentation.Utils.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElCerrojoPresentation.Utils
{
    public static class CustomComboBox
    {
        public static void InsertItems(this ComboBox combo, ComboOption[] items)
        {
            if (items != null && items.Length > 0)
            {
                combo.Items.AddRange(items);
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                //combo.SelectedIndex = 0;
            }
        }

        public static void SetValue(this ComboBox combo, int valor)
        {
            foreach (ComboOption opcion in combo.Items)
            {
                if (opcion.Value == valor)
                {
                    combo.SelectedItem = opcion;
                    break;
                }
            }
        }

    }
}
