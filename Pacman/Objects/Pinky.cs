using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace Pacman.Objects
{
    class Pinky : Enemy
    {
        //Pinky, a child class from Enemy.
        //Pinky is simple, she just chases pacman
        public Pinky(Vector2 position) : base("spr_pinky")
        {
            this.position = position;
            Reset();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

        }




    }
}
