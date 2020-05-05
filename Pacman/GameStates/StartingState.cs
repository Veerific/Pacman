using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pacman.GameStates
{
    class StartingState : GameObjectList
    {
        private SpriteGameObject startingScreen;
        
        public StartingState()
        {
            
            startingScreen = new SpriteGameObject("startscreen");
            this.Add(startingScreen);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            if (inputHelper.AnyKeyPressed)
            {
                GameEnvironment.GameStateManager.SwitchTo("PlayingState");
            }
        }
    }
}
