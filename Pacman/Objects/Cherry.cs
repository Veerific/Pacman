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
    class Cherry : SpriteGameObject
    {
        private bool hasEaten;
        private const int CHERRY_SCORE = 10;
        public Cherry(Vector2 position) : base("spr_cherry")
        {
            Reset();
            this.position = position;
        }

        public override void Reset()
        {
            base.Reset();
        }
        
        public bool GetHasEaten()
        {
            return hasEaten;
        }
        public void SetHasEaten(bool b)
        {
            this.hasEaten = b;
        }
        public int GetScore()
        {
            return CHERRY_SCORE;
        }
    }
}
