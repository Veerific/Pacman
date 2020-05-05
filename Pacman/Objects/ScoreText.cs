using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Pacman.Objects
{
    class ScoreText : TextGameObject
    {

        private int score;
        
        public ScoreText(Vector2 position) : base("ScoreText",1, "")
        {
            this.position = position;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            text = "" + score;

        }
        public void AddScore(int score)
        {
            this.score += score;
            
        }
    }
}
