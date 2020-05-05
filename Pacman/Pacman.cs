using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pacman.GameStates;



namespace Pacman
{
    class Pacman : GameEnvironment
    {
        protected override void LoadContent()
        {
            base.LoadContent();
            screen = new Point(1000,600);
            ApplyResolutionSettings();

            GameStateManager.AddGameState("StartState", new StartingState());
            gameStateManager.AddGameState("PlayingState", new PlayingState());
            gameStateManager.SwitchTo("StartState");
            if(gameStateManager.CurrentGameState == gameStateManager.GetGameState("StartState"))
            {
                if (inputHelper.AnyKeyPressed)
                {
                    gameStateManager.SwitchTo("PlayingState");
                }
            }
        }
    }
}
