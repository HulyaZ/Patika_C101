using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patika_C101_OOP
{
    public class Animals:LivingThings
    {
    
        protected void Adaptation()
        {
            Console.WriteLine("Hayvanlar adaptasyon yeteneğine sahiptir.");
        }

        public override void ReactiontoStimulus()
        {
            base.ReactiontoStimulus();
            Console.WriteLine("Hayvanlar temasa tepki verir.");
        }
    }

    public class Reptiles:Animals
    {
        public Reptiles()
        {
            base.Nutrition();
            base.Respiration();
            base.Excretion();
            base.Adaptation();
        }
        public void ReptileMovement()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Birds:Animals
    {
        public Birds()
        {
            base.Nutrition();
            base.Respiration();
            base.Excretion();
            base.Adaptation();
            base.ReactiontoStimulus();
        }
        public void BirdMovement()
        {
            Console.WriteLine("Kuşlar uçar.");
        }

    }
}
