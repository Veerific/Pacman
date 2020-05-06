using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GameStates
{
    class DeathState : GameObjectList
    {
        //the deathstate
        //when you die, the game will be in this state and show the deathscreen
        private SpriteGameObject deathScreen;

        public DeathState()
        {

            deathScreen = new SpriteGameObject("deathscreen");
            this.Add(deathScreen);
        }
        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            //after pressing any key you will go back to the start
            if (inputHelper.AnyKeyPressed)
            {
              
                
                GameEnvironment.GameStateManager.SwitchTo("StartingState");
            }
        }

    }
}
