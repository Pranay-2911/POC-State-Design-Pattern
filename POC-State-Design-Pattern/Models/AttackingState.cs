using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State_Design_Pattern.Models
{
    internal class AttackingState : ICharacterState
    {
        public void HandleInput(Character character, string input)
        {
            if (input == "idle")
            {
                Console.WriteLine("Character finishes attack and goes idle");
                character.SetState(new IdleState());
            }
            else if (input == "walk")
            {
                Console.WriteLine("Character finishes attack and starts walking");
                character.SetState(new WalkingState());
            }
            else if (input == "run")
            {
                Console.WriteLine("Character finishes attack and starts running");
                character.SetState(new RunningState());
            }
        }

        public void DisplayState(Character character)
        {
            Console.WriteLine("Character is attacking");
        }
    }
}
