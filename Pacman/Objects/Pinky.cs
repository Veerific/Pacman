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
        public Pinky(Vector2 position) : base("spr_pinky")
        {
            this.position = position;
            Reset();
        }
        public void Reset()
        {
            velocity = new Vector2(5,5);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            
        }


    }
}
