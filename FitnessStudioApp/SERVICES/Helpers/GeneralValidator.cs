using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES.Helpers
{
    public static class GeneralValidator
    {
        public static bool ListBoxIndexChecked(ListBox listBox)
        {
            if (listBox.SelectedIndex < 0)
            {
                return false;
            }
            return true;
        }
    }
}
