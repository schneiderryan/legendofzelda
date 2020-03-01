using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LegendOfZelda
{
    class DamagedGoriya : IEnemy
    {
        public IEnemy decoratedGoriya;
        LegendOfZelda game;

        int timer = 192; // to give about 3 seconds

        public Rectangle Hitbox
        {
            get { return decoratedGoriya.Hitbox; }
        }

        public ISprite sprite
        {
            get { return decoratedGoriya.sprite; }
            set { decoratedGoriya.sprite = value; }
        }

        public IEnemyState state
        {
            get { return decoratedGoriya.state; }
            set { decoratedGoriya.state = value; }
        }

        public int X
        {
            get { return decoratedGoriya.X; }
            set { decoratedGoriya.X = value; }
        }

        public int Y
        {
            get { return decoratedGoriya.Y; }
            set { decoratedGoriya.Y = value; }
        }

     
       
        public double currentHearts
        {
            get { return decoratedGoriya.currentHearts; }
            set { decoratedGoriya.currentHearts = value; }
        }

        public int CurrentStep { get ; set ; }
        public int changeDirection { get; set ; }
        public int xVel { get ; set ; }
        public int yVel { get ; set ; }
        public bool isBeingAttacked { get ; set; }
        public int listIndex { get ; set ; }

        public DamagedGoriya(LegendOfZelda game)
        {

            this.game = game;
            foreach(IEnemy enemy in game.currentRoom.enemies)
            {
                if (enemy.isBeingAttacked)
                {
                   
                    this.decoratedGoriya = enemy;
                }
            }
            
        }


   

        public void Draw(SpriteBatch sb, Color color)
        {
            // rgba
            Color hurt1 = new Color(83, 68, 198);
            Color hurt2 = new Color(184, 101, 22);
            Color hurt3 = new Color(76, 80, 69);

            if (timer<=8 || timer>=33 && timer<=40 || timer>=65 && timer<=72 || timer>=97 && timer<=104 || timer>=129 && timer<=136 || timer>=161 && timer<=168)
            {
                decoratedGoriya.Draw(sb, hurt1);
            }
            else if (timer<=16 || timer>=41 && timer<=48 || timer>=73 && timer<= 80 || timer>=105 && timer<=112 || timer>=137 && timer<=144 || timer>=169 && timer<=176)
            {
                decoratedGoriya.Draw(sb, hurt2);
            }
            else if (timer<=24 || timer>=49 && timer<=56 || timer>=81 && timer<=88 || timer>=113 && timer<=120 || timer>=145 && timer<=152 || timer>=177 && timer<=184)
            {
                decoratedGoriya.Draw(sb, hurt3);
            }
            else
            {
                decoratedGoriya.Draw(sb, Color.White);
            }
            
        }

        public void MoveDown()
        {
            decoratedGoriya.MoveDown();
        }

        public void MoveLeft()
        {
            decoratedGoriya.MoveLeft();
        }

        public void MoveRight()
        {
            decoratedGoriya.MoveRight();
        }

        public void MoveUp()
        {
            decoratedGoriya.MoveUp();
        }

        

        public void Update()
        {
            timer--;
            if (timer == 0)
            {
                foreach (IEnemy enemy in game.currentRoom.enemies.ToList())
                {
                    if (enemy.isBeingAttacked)
                    {
                        this.game.currentRoom.enemies[enemy.listIndex] = decoratedGoriya;
                        isBeingAttacked = false;
                    }
                    
                }
            }
            decoratedGoriya.Update();
        }

        public void BeStill()
        {
            decoratedGoriya.BeStill();
        }

       

        public void UseProjectile(IProjectile projectile)
        {
            decoratedGoriya.UseProjectile(projectile);
        }

        public void Use(IEnemy enemy)
        {
            decoratedGoriya.Use(enemy);
        }

        public void TakeDamage()
        {
            //nothing
        }
    }
}
