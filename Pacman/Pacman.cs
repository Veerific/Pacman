﻿using System;
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

            gameStateManager.AddGameState("StartingState", new StartingState());
            gameStateManager.AddGameState("DeathState", new DeathState());
            gameStateManager.AddGameState("PlayingState", new PlayingState());
            gameStateManager.AddGameState("WinState", new WinState());
            gameStateManager.SwitchTo("StartingState");
            
        }
    }
}
