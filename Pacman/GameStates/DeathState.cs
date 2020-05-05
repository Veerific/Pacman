using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GameStates
{
    class DeathState : GameObjectList
    {
        private SpriteGameObject deathScreen;

        public DeathState()
        {

            deathScreen = new SpriteGameObject("deathscreen");
            this.Add(deathScreen);
        }
        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.AnyKeyPressed)
            {
              
                
                GameEnvironment.GameStateManager.SwitchTo("StartingState");
            }
        }

    }
}
