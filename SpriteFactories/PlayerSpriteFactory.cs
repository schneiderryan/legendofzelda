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
        private Texture2D upStillLink;
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
            upStillLink = content.Load<Texture2D>("StillLinkUp");
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
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(60, 60, 18, 26), 2, false);
        }

        public ISprite CreateDownAttackingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(0, 60, 18, 26), 2, false);
        }

        public ISprite CreateLeftStillLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(30, 0, 15, 16);

            Texture2D leftStillLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            leftStillLink.SetData(data);
            return new Sprite(leftStillLink, new Rectangle(0, 0, 15, 16));
        }

        public ISprite CreateRightStillLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(90, 30, 15, 16);

            Texture2D rightStillLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            rightStillLink.SetData(data);
            return new Sprite(rightStillLink, new Rectangle(0, 0, 15, 16));
        }

        public ISprite CreateUpStillLinkSprite()
        {   
            return new Sprite(upStillLink, new Rectangle(0, 0, upStillLink.Width, upStillLink.Height));
        }

        public ISprite CreateDownStillLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(30, 0, 14, 16);

            Texture2D downStillLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            downStillLink.SetData(data);
            return new Sprite(downStillLink, new Rectangle(0, 0, 14, 16));
        }
    }
}
