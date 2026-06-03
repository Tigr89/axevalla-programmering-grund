using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoW_Ability_Breakdown
{
    class FrostBolt
    {
        Random random = new Random();

        string abilityName = "Frost Bolt";
        int resource = 25;
        float castTime = 1.5f;
        int requiredLevel = 4;
        float maxRange = 30;
        float minRange = 0;
        int minDamage = 18;
        int maxDamage = 20;
        string damageType = "Frost";
        string effectType = "Slow";
        int effect = 40;
        float effectTime = 5;

        //TALENTS 
        int piercingIce = 3;

        public void UseAbility()
        {
            while (true)
            {
                Console.WriteLine("Frost bolt does: " + DamageCalculation() + " damage!");
                Console.ReadLine();
            }


            float DamageCalculation()
            {
                float returnDamage = random.Next(minDamage, maxDamage + 1);
                float damageModifier = 1;

                if (damageType == "Frost")
                {
                    switch (piercingIce)
                    {
                        case 1:
                            damageModifier = 1.02f;
                            break;
                        case 2:
                            damageModifier = 1.04f;
                            break;
                        case 3:
                            damageModifier = 1.06f;
                            break;
                        default:
                            damageModifier = 1;
                            break;
                    }

                    returnDamage = returnDamage * damageModifier;
                }

                return returnDamage;
            }


            
        }
            
    }
}

