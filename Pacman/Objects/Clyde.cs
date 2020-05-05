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
    class Clyde : Enemy
    {
        public Clyde(Vector2 position) : base("spr_clyde")
        {
            this.position = position;
        }
    }
}
