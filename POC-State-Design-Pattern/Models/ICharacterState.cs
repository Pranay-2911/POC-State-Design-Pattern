using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State_Design_Pattern.Models
{
    internal interface ICharacterState // Interface representing a state for the Character
    {
        public void HandleInput(Character character, string input); // Change the state
        public void DisplayState(Character character);   // Display the State
    }
}
