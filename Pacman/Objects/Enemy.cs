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
    class Enemy : RotatingSpriteGameObject
    {
        private float speed = 3;
        private bool isEatable;
        public Enemy(String assetName) : base(assetName)
        {
           
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            position += velocity;
            isEatable = false;

            if (isEatable)
            {
                position.Y = MathHelper.Clamp(position.Y, 0 + sprite.Height / 2, 1000);
            }


        }

        public float GetSpeed()
        {
            return speed;
        }

        public bool GetIsEatable()
        {
            return isEatable;
        }
        public void SetIsEatable(bool b)
        {
            this.isEatable = b;
        }      
    }
}
