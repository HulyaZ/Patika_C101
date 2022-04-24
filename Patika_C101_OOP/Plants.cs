using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_C101_OOP
{
    public class Plants : LivingThings
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");

        }
        public override void ReactiontoStimulus()
        {
            //base.ReactiontoStimulus();
            Console.WriteLine("Bitkiler güneşe tepki verir.");
        }
    }

    public class SeedPlants : Plants
    {
        public SeedPlants()
        {
            base.Photosynthesis();
            base.Respiration();
            base.Nutrition();
            base.Excretion();
            base.ReactiontoStimulus();
        }

        public void seedReproduction()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }

    public class SeedlessPlants : Plants
    {
        public SeedlessPlants()
        {
            base.Photosynthesis();
            base.Respiration();
            base.Nutrition();
            base.Excretion();
        }
        public void seedlessReproduction()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }

    }
}
