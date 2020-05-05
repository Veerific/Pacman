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
    class Player : RotatingSpriteGameObject
    {
        
      

        public Player(Vector2 position) : base("spr_pacman")
        {
            this.position = position;
            Reset();

        }
        public override void Reset()
        {
            base.Reset();
            velocity = new Vector2(5,5);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);
            //movement input for the player
            if (inputHelper.IsKeyDown(Keys.W) || inputHelper.IsKeyDown(Keys.Up))
            {
                position.Y -= velocity.Y;
                Degrees = 270;
            }
            if (inputHelper.IsKeyDown(Keys.S) || inputHelper.IsKeyDown(Keys.Down))
            {
                position.Y += velocity.Y;
                Degrees = 90;
            }
            if (inputHelper.IsKeyDown(Keys.D) || inputHelper.IsKeyDown(Keys.Right))
            {
                position.X += velocity.X;
                Degrees = 0;
            }
            if (inputHelper.IsKeyDown(Keys.A) || inputHelper.IsKeyDown(Keys.Left))
            {
                position.X -= velocity.X;
                Degrees = 180;
                
            }
            
        }
    }
}
