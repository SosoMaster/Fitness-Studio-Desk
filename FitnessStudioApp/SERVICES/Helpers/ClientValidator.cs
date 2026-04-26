using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES.Helpers;

public static class ClientValidator
{
    public static bool InfoFieldsValidate(Client client)
    {
        if (client.Trainer == null)
        {
            return false;
        }
        return true;
    }

}
