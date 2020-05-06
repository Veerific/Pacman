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
    //the playing state, the main state of the game
    //here comes all the gameplay
    class PlayingState : GameObjectList
    {
        
        Player player;
        Box box1;
        Box box2;
        Cherry cherry;
        ScoreText scoreText;
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
            cherry = new Cherry(new Vector2(750, 550));
            this.Add(cherry);
            //the player
            player = new Player(new Vector2(500, 300));
            this.Add(player);

            //the ghosts
            ghosts.Add(new Pinky(new Vector2(500, 500)));
            ghosts.Add(new Clyde(new Vector2(950, 300)));

            //scoretext
            scoreText = new ScoreText(new Vector2(490, 300));
            
            this.Add(scoreText);


            base.Reset();
            
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            //to prevent the player from going into the box

            if (player.CollidesWith(box1) || player.CollidesWith(box2))
            {
                player.SetVelocityX(player.GetKnockback());
                player.SetVelocityY(player.GetKnockback());
            }
            else
            {
                player.Reset();
            }
            //when the player eats the cherry, it will disappear
            if (player.CollidesWith(cherry))
            {
                cherry.SetHasEaten(true);
                scoreText.AddScore(cherry.GetScore());
                children.Remove(cherry);
            }



            foreach (Enemy enemy in ghosts.Children)
            {
                //if the cherry is eaten, the ghosts will become edible
                if (cherry.GetHasEaten())
                {
                    enemy.SetIsEatable(true);

                }
                switch (enemy.GetIsEatable())
                {
                    //if the cherry has not been eaten yet, the ghosts will eat you
                    case false:
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
                            if (enemy.GetPositionX() == player.GetPositionX())
                            {
                                enemy.SetVelocityX(0);
                            }
                        }
                        //once the x is aligned, it will check the y
                        //if the y is not aligned with the players, it will follow the player's y accordingly
                        if (enemy.GetPositionY() != player.GetPositionY())
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
                            enemy.SetVelocityX(enemy.GetKnockback());
                            enemy.SetVelocityY(enemy.GetKnockback()); ;
                        }
                        else
                        {
                            enemy.Reset();
                        }
                        //if the ghost touches the player, the player dies and switches to the death screen
                        if (enemy.CollidesWith(player))
                        {
                            GameEnvironment.GameStateManager.SwitchTo("DeathState");
                            Reset();
                        }
                        break;
                    case true:
                        
                        //if the player picks up the cherry, ghosts will become edible
                        //ghosts will run away as a result
                        //if the x is the same, they will try to run away
                            if (enemy.GetPositionX() == player.GetPositionX())
                            {
                                if (enemy.GetPositionX() < player.GetPositionX())
                                {
                                    enemy.SetVelocityX(-enemy.GetRunawaySpeed());
                                }
                                if (enemy.GetPositionX() > player.GetPositionX())
                                {
                                    enemy.SetVelocityX(enemy.GetRunawaySpeed());
                                }

                            }
                            //if the y is the same, they will try to leave
                            if (enemy.GetPositionY() == player.GetPositionY())
                            {
                                if (enemy.GetPositionY() < player.GetPositionY())
                                {
                                    enemy.SetVelocityY(-enemy.GetRunawaySpeed());
                                }
                                if (enemy.GetPositionY() > player.GetPositionY())
                                {
                                    enemy.SetVelocityY(enemy.GetRunawaySpeed());
                                }
                            }
                        //if the player eats the ghost, the ghosts die
                        if (enemy.CollidesWith(player))
                        {//once the player eats a ghost, it will switch to the winstate
                            GameEnvironment.GameStateManager.SwitchTo("WinState");
                            Reset();

                        }

                        
                        break;
                }


            }
            
        }
    }
}
