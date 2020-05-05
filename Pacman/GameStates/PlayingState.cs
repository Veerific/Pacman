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
        
        
        public PlayingState()
        {
            Reset();
        }
        
        public override void Reset()
        {
            children.Clear();

            //adding the gameobjectlists into the lists
            ghosts = new GameObjectList();
            this.Add(ghosts);
         

            //the boxes that create the map
            box1 = new Box(new Vector2(275, 300));
            box2 = new Box(new Vector2(725, 300));
            this.Add(box1);
            this.Add(box2);

            //the player
            player = new Player(new Vector2(500, 300));
            this.Add(player);

            //the ghosts
            ghosts.Add(new Pinky(new Vector2(500, 500)));
            ghosts.Add(new Clyde(new Vector2(900, 300)));

            base.Reset();
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            //to prevent the player from going into the box

            if (player.CollidesWith(box1) || player.CollidesWith(box2))
            {
                player.SetVelocityX(-15);
                player.SetVelocityY(-15);
            }
            else
            {
                player.Reset();
            }



            //the ghost ai 
            foreach (Enemy enemy in ghosts.Children)
            {
                //if the x is not aligned with the player, it will follow the player's x accordingly
                if (enemy.GetPositionX() != player.GetPositionX())
                {
                    if (enemy.GetPositionX() < player.GetPositionX())
                    {
                        enemy.SetVelocityX(enemy.GetSpeed());
                    }
                    if (enemy.GetPositionX() > player.GetPositionX())
                    {
                        enemy.SetVelocityX(-enemy.GetSpeed());
                    }
                    if(enemy.GetPositionX() == player.GetPositionX())
                    {
                        enemy.SetVelocityX(0);
                    }
                }
                //once the x is aligned, it will check the y
                //if the y is not aligned with the players, it will follow the player's y accordingly
                if ( enemy.GetPositionY() != player.GetPositionY())
                {
                    if (enemy.GetPositionY() < player.GetPositionY())
                    {
                        enemy.SetVelocityY(enemy.GetSpeed());
                    }
                    if (enemy.GetPositionY() > player.GetPositionY())
                    {
                        enemy.SetVelocityY(-enemy.GetSpeed());
                    }
                }
                //to make sure the ghost doesnt go through the box
                if (enemy.CollidesWith(box1) || enemy.CollidesWith(box2))
                {
                    enemy.SetVelocityX(-1);
                    enemy.SetVelocityY(-1);
                }
                else
                {
                    enemy.Reset();
                }
                //if the ghost touches the player, the player dies and switches to the death screen
                if (enemy.CollidesWith(player))
                {
                    GameEnvironment.GameStateManager.SwitchTo("DeathState");
                    this.Reset();
                }

            }
            
        }
    }
}
