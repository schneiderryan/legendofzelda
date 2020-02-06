﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class PlayerSpriteFactory
    {
        private Texture2D linkSpriteSheet;
        private Texture2D linkAttackingDown;
        private Texture2D linkAttackingUp;
        private Texture2D redLinkAttackingDown;
        private Texture2D redLinkAttackingUp;
        private static PlayerSpriteFactory instance = new PlayerSpriteFactory();

        private PlayerSpriteFactory() { }

        public static PlayerSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public void LoadTextures(ContentManager content)
        {
            linkSpriteSheet = content.Load<Texture2D>("link");
            linkAttackingDown = content.Load<Texture2D>("downAttackingLink");
            linkAttackingUp = content.Load<Texture2D>("upAttackingLink");
            redLinkAttackingDown = content.Load<Texture2D>("downAttackingRedLink");
            redLinkAttackingUp = content.Load<Texture2D>("upAttackingRedLink");

        }

        //Green Link Sprites

        public ISprite CreateLeftWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(30, 0, 15, 15), 2, false);
        }

        public ISprite CreateRightWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(90, 0, 15, 15), 2, false);
        }

        public ISprite CreateUpWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(60, 0, 15, 15), 2, false);
        }

        public ISprite CreateDownWalkingLinkSprite()
        {
           return new AnimatedSprite(linkSpriteSheet, new Rectangle(0, 0, 15, 15), 2, false);
        }

        public ISprite CreateLeftAttackingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(24, 60, 28, 15), 2, false);
        }

        public ISprite CreateRightAttackingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(84, 60, 28, 15), 2, false);
        }

        public ISprite CreateUpAttackingLinkSprite()
        {
            return new AnimatedSprite(linkAttackingUp, new Rectangle(0, 0, 17, linkAttackingUp.Height), 2, true);
        }

        public ISprite CreateDownAttackingLinkSprite()
        {
            return new AnimatedSprite(linkAttackingDown, new Rectangle(0, 0, 17, linkAttackingDown.Height), 2, true);
        }

        public ISprite CreateLeftStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(30, 0, 16, 17));
        }

        public ISprite CreateRightStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(90, 0, 15, 17));
        }

        public ISprite CreateUpStillLinkSprite()
        {   
            return new Sprite(linkSpriteSheet, new Rectangle(62, 0, 12, 17));
        }

        public ISprite CreateDownStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(0, 0, 15, 17));
        }

        //Red Link Sprites

        public ISprite CreateRedLeftWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(270, 0, 15, 15), 2, false);
        }

        public ISprite CreateRedRightWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(330, 0, 15, 15), 2, false);
        }

        public ISprite CreateRedUpWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(302, 0, 15, 15), 2, false);
        }

        public ISprite CreateRedDownWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(240, 0, 15, 15), 2, false);
        }

        public ISprite CreateRedLeftAttackingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(264, 60, 28, 15), 2, false);
        }

        public ISprite CreateRedRightAttackingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(324, 60, 28, 15), 2, false);
        }

        public ISprite CreateRedUpAttackingLinkSprite()
        {
            return new AnimatedSprite(redLinkAttackingUp, new Rectangle(0, 0, 19, redLinkAttackingUp.Height), 2, true);
        }

        public ISprite CreateRedDownAttackingLinkSprite()
        {
            return new AnimatedSprite(redLinkAttackingDown, new Rectangle(0, 0, 19, redLinkAttackingDown.Height), 2, true);
        }

        public ISprite CreateRedLeftStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(270, 0, 16, 17));
        }

        public ISprite CreateRedRightStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(330, 0, 15, 17));
        }

        public ISprite CreateRedUpStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(302, 0, 12, 17));
        }

        public ISprite CreateRedDownStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(240, 0, 15, 17));
        }
    }
}
