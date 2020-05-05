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
    class Box : SpriteGameObject
    {
        public Box(Vector2 position) : base("spr_box", 0, "", 0)
        {
            this.position = position;
        }
    }
}
