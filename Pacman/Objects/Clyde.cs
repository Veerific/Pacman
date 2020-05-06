using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pacman.Objects
{
    //one of the ghosts, CLyde
    class Clyde : Enemy
    {
        private float clydeCooldown = 150;
        public Clyde(Vector2 position) : base("spr_clyde")
        {
            this.position = position;
            Reset();
        }

        public override void Update(GameTime gameTime)
        {
            //Clyde has a cooldown. He waits a little bit before he will move
            clydeCooldown--;
            //once his cooldown is below zero, he will chase the player
            if(clydeCooldown < 0)
            {
                base.Update(gameTime);
            }
        }

      
    }
}
