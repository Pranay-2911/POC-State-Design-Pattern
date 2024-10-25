using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State_Design_Pattern.Models
{
    internal class WalkingState :ICharacterState
    {
        public void HandleInput(Character character, string input)
        {
            if (input == "run")
            {
                Console.WriteLine("Character starts running");
                character.SetState(new RunningState());
            }
            else if (input == "attack")
            {
                Console.WriteLine("Character starts attacking");
                character.SetState(new AttackingState());
            }
            else if (input == "idle")
            {
                Console.WriteLine("Character goes idle");
                character.SetState(new IdleState());
            }
        }

        public void DisplayState(Character character)
        {
            Console.WriteLine("Character is walking");
        }
    }
}
