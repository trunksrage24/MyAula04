using System;

namespace NPCPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables //
            string npcAmount;
            string StealtH;
            string CombaT;
            string LockpicK;
            string LucK;
            int npcAmounT;

            // Ask for NPC amount //
            Console.WriteLine("How many NPC's would you like to create");
            npcAmount = Console.ReadLine();
            npcAmounT = Convert.ToInt32(npcAmount);

            // Create an array //
            NPCPerks[] Perks = new NPCPerks[3];

            // Each NPC's characteristics //
            for (int i = 0; i < npcAmounT; i++)
            {
                // Ask if NPC is Stealth //
                // Add Stealth to NPC's perks //
                Console.WriteLine("Does this NPC get Stealth? (y/n)");
                StealtH = Console.ReadLine();
                if (StealtH == "y")
                {
                    Perks[i] |= NPCPerks.Stealth;
                }
                else
                {
                    continue;
                }

                // Ask if NPC is Combat //
                // Add Combat to NPC's perks //
                Console.WriteLine("Does this NPC get Combat? (y/n)");
                CombaT = Console.ReadLine();
                if (CombaT == "y")
                {
                    Perks[i] |= NPCPerks.Combat;
                }
                else
                {
                    continue;
                }

                // Ask if NPC is Lockpick //
                // Add Lockpick to NPC's perks //
                Console.WriteLine("Does this NPC get Lockpick? (y/n)");
                LockpicK = Console.ReadLine();
                if (LockpicK == "y")
                {
                    Perks[i] |= NPCPerks.Lockpick;
                }
                else
                {
                    continue;
                }

                // Ask if NPC is Luck //
                // Add Luck to NPC's perks //
                Console.WriteLine("Does this NPC get Luck? (y/n)");
                LucK = Console.ReadLine();
                if (LucK == "y")
                {
                    Perks[i] |= NPCPerks.Luck;
                }
                else
                {
                    continue;
                }
            }
            // Show characteristics //
            for (int i = 0; i < npcAmounT; i++)
            {
                // Show characteristics of current NPC //
            }
        }
    }
}
