using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_State_Design_Pattern.Models
{
    internal class Character
    {
        private ICharacterState _characterState;

        public Character()
        {
            // Default state is Idle when the character is created
            _characterState = new IdleState();
        }

        public void SetState(ICharacterState state) // method to set new State
        {
            _characterState = state;
        }

        public void HandleInput(string input)
        {
            _characterState.HandleInput(this, input);
        }

        public void GetState()
        {
            _characterState.DisplayState(this);
        }
    }
}
