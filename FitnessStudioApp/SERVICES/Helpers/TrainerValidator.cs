using FitnessStudioApp.MODELS;
using System;

namespace FitnessStudioApp.SERVICES.Helpers;

public static class TrainerValidator
{
    public static bool InfoFieldsValidate(Trainer trainer)
    {
        if (trainer == null || trainer.UserId <= 0)
        {
            return false;
        }
        return true;
    }
}
