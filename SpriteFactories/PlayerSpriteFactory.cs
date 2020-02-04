using Microsoft.Xna.Framework;
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
        }

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
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(60, 50, 18, 31), 2, false);
        }

        public ISprite CreateDownAttackingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(0, 60, 18, 26), 2, false);
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
    }
}
