using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State_Design_Pattern.Models
{
    internal class RunningState : ICharacterState
    {
        public void HandleInput(Character character, string input)
        {
            if (input == "walk")
            {
                Console.WriteLine("Character slows down to a walk");
                character.SetState(new WalkingState());
            }
            else if (input == "attack")
            {
                Console.WriteLine("Character starts attacking");
                character.SetState(new AttackingState());
            }
            else if (input == "idle")
            {
                Console.WriteLine("Character stops running and goes idle");
                character.SetState(new IdleState());
            }
        }

        public void DisplayState(Character character)
        {
            Console.WriteLine("Character is running");
        }
    }
}
