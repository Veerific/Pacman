using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GameStates
{
    class WinState : GameObjectList
    {//this is the win state, it shows the winscreen
        private SpriteGameObject winScreen;
        public WinState()
        {
            winScreen = new SpriteGameObject("winscreen");
            children.Add(winScreen);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            //if any key is pressed, it will go back to the starting screen
            if (inputHelper.AnyKeyPressed)
            {
                GameEnvironment.GameStateManager.SwitchTo("StartingState");
            }
        }
    }
}
