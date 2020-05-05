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
        public Enemy(String assetName) : base(assetName)
        {

        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

    }
}
