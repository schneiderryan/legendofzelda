﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class RedLink : IPlayer 
    {
        public LegendOfZelda game;
        public ISprite sprite;
        public ILinkState state;
        private int itemTimer;
        private int x;
        private int y;
        private String d;

        public int xPos
        {
            get { return x; }
            set { x = value; }
        }

        public int yPos
        {
            get { return y; }
            set { y = value; }
        }

        public String direction
        {
            get { return d; }
            set { d = value; }
        }

        public RedLink(LegendOfZelda game)
        {
            this.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.direction = "up";
            this.sprite.Scale = 2.0f;
            this.xPos = 400;
            this.yPos = 200;
            this.sprite.Position = new Point(xPos, yPos);
            this.state = new StillUpRedLinkState(this);
            this.game = game;
            this.itemTimer = 0;
        }

        public void MoveLeft()
        {
            state.MoveLeft();
        }

        public void MoveRight()
        {
            state.MoveRight();
        }
        
        public void MoveUp()
        {
            state.MoveUp();
        }

        public void MoveDown()
        {
            state.MoveDown();
        }

        public void Attack()
        {
            state.Attack();
        }

        public void BeStill()
        {
            state.BeStill();
        }

        public void Update()
        {
            state.Update();
            sprite.Update();
            if(itemTimer > 0)
            {
                itemTimer--;
            }
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public void UseItem(IProjectile item)
        {
            if (itemTimer == 0)
            {
                itemTimer = 75;
                game.projectiles.Add(item);
            }
        }

        public void TakeDamage()
        {
            this.game.link = new DamagedLink(this, this.game);
        }
    }
}
