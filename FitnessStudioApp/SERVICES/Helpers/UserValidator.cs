using FitnessStudioApp.MODELS;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FitnessStudioApp.SERVICES.Helpers
{
    public static class UserValidator
    {
        public static bool InfoFieldsValidate(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) ||
                string.IsNullOrWhiteSpace(user.Email) ||
                string.IsNullOrWhiteSpace(user.Phone) ||
                string.IsNullOrWhiteSpace(user.Password))
            {
                return false;
            }
            return true;
        }

        // Accepts: +359 followed by exactly 9 digits, OR 0 followed by exactly 9 digits
        public static bool ValidatePhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone)) return false;
            return Regex.IsMatch(phone, @"^(\+359|0)\d{9}$");
        }

        public static bool ListBoxIndexChecked(ListBox listBox)
        {
            if (listBox.SelectedIndex < 0) return false;
            return true;
        }
    }
}