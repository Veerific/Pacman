using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.GameStates
{
    class WinState : GameObjectList
    {
        private SpriteGameObject winScreen;
        public WinState()
        {
            winScreen = new SpriteGameObject("winscreen");
            children.Add(winScreen);
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
