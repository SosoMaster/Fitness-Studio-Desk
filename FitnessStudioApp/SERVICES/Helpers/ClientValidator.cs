using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.SERVICES.Helpers;

public static class ClientValidator
{
    public static void InfoFieldsValidate(Client client)
    {
        if (string.IsNullOrEmpty(client.MembershipStatus)||
            client.Trainer == null)
        {
            throw new Exception("Invalid info");
        }
    }

}
