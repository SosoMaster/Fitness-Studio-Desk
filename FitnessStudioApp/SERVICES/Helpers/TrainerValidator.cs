using FitnessStudioApp.MODELS;
using System;

namespace FitnessStudioApp.SERVICES.Helpers;

public static class TrainerValidator
{
    public static void InfoFieldsValidate(Trainer trainer)
    {
        if (trainer == null || trainer.UserId <= 0)
        {
            throw new Exception("Invalid trainer data");
        }
    }
}
