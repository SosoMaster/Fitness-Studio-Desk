using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessStudioApp.REPOSITORY
{
    internal interface IProgressRepository : IRepositroy  // въпроса за сега е трябва ли да наследява IRepositroy, но за сега ще го оставя така, ако се наложи ще го премахна
    {
        void GainWeight(string userId, double weight);
        void LoseWeight(string userId, double weight);
        void GainMuscle(string userId, double weight, double bodyfat);

        // трябва навярно да променим servicesите защото в момента нямат логкиа спрямо това а то трянва да е така.
    }
}
