using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_Ability_Breakdown
{
    class EarthShock
    {
        int resource = 30;
        int requiredLevel = 4;
        int maxRange = 20;
        int minRange = 0;
        float coolDown = 6;
        float castTime = 0;
        float minDamage = 19;
        float maxDamage = 22;
        string damageType = "Nature";
        string effectType = "Interrupt";
        int effect = 0;
        float effectTime = 2;

        //TALENTS
        int reverberation = 3;

            while (true)
            {
                Console.WriteLine("Cooldown is: " + UpdateCooldown() + " seconds");
                Console.ReadLine();
            }

            float UpdateCooldown()
        {
            float returnValue = coolDown;
            float cooldownModifier = 0.2f;

            cooldownModifier = cooldownModifier * reverberation;

            if (reverberation > 0) returnValue = returnValue - cooldownModifier;


            return returnValue;
        }

        void CheckIfInstant()
        {

        }
    }
}
