using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Pacman.Objects;

namespace Pacman.GameStates
{
    class PlayingState : GameObjectList
    {
        Player player;
        Box box1;
        Box box2;

        GameObjectList ghosts;
        GameObjectList boxes;
        
        
        public PlayingState()
        {
            Reset();
        }
        
        public override void Reset()
        {
            boxes = new GameObjectList();
            this.Add(boxes);
            box1 = new Box(new Vector2(250, 300));
            box2 = new Box(new Vector2(750, 300));
            boxes.Add(box1);
            boxes.Add(box2);
            player = new Player(new Vector2(500, 300));
            this.Add(player);

            ghosts = new GameObjectList();
            this.Add(ghosts);
            ghosts.Add(new Pinky(new Vector2(500, 500)));

            base.Reset();
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach(Box box in boxes.Children)
            {
                //fix box collision
                if (player.CollidesWith(box))
                {
                    player.Velocity = -player.Velocity;
                }
                if(box == box1)
                {
                    if (player.CollidesWith(box))
                    {
                        player.Velocity = -player.Velocity;
                    }
                }
                else
                {
                    player.Reset();
                }
                
            }
      

            
        }
        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            base.Draw(gameTime, spriteBatch);
        }

    }
}
