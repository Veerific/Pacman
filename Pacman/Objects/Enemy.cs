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
    //the main enemy class
    class Enemy : RotatingSpriteGameObject
    {
        private float speed = 3;
        private float runawaySpeed = 7;
        private int knockback;
        private bool isEatable;
        public Enemy(String assetName) : base(assetName)
        {
            Reset();
        }
        public override void Reset()
        {
            base.Reset();
            isEatable = false;
            knockback = -1;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            position += velocity;
            
        }
        public int GetKnockback()
        {
            return knockback;
        }

        public float GetRunawaySpeed()
        {
            return runawaySpeed;
        }
        public float GetSpeed()
        {
            return speed;
        }

        //booleans for when they are edible

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
