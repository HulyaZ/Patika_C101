using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_C101_OOP
{
    //bir class başka bir sınıfa kalıtım veremesin istersen sealed
    public class LivingThings
    {
        protected void Nutrition()
        {
            Console.WriteLine("Canlılar beslenir.");

        }

        protected void Respiration()
        {
            Console.WriteLine("Canlılar solunum yapar.");

        }

        protected void Excretion()
        {
                Console.WriteLine("Canlılar boşaltım yapar.");

        }

        public virtual void ReactiontoStimulus()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir.");

        }
    }
}
