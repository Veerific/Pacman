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
        //scoretext class

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
        //method to add score during a certain event
        public void AddScore(int score)
        {
            this.score += score;
            
        }
    }
}
