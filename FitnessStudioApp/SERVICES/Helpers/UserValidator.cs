using FitnessStudioApp.MODELS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES.Helpers
{
    public static class UserValidator
    {
        public static bool InfoFieldsValidate(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username)||
                string.IsNullOrWhiteSpace(user.Email)   ||
                string.IsNullOrWhiteSpace(user.Phone)   ||
                string.IsNullOrWhiteSpace(user.Password))
            {
                return false;
                throw new Exception("Invalid data");
            }
            return true;
        }


    }
}
