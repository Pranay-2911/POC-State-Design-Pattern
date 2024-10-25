using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State_Design_Pattern.Models
{
    internal class IdleState : ICharacterState
    {
        public void HandleInput(Character character, string input)
        {
            if (input == "walk")
            {
                Console.WriteLine("Character starts walking");
                character.SetState(new WalkingState());
            }
            else if (input == "run")
            {
                Console.WriteLine("Character starts running");
                character.SetState(new RunningState());
            }
            else if (input == "attack")
            {
                Console.WriteLine("Character starts attacking");
                character.SetState(new AttackingState());
            }
        }

        public void DisplayState(Character character)
        {
            Console.WriteLine("Character is idle");
        }
    }
}
