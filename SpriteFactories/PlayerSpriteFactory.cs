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
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(30, 0, 15, 46);

            Texture2D leftWalkingLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            leftWalkingLink.SetData(data);
            return new AnimatedSprite(leftWalkingLink, new Rectangle(0, 0, 15, 23), 2, false);
        }

        public ISprite CreateRightWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet,
                    new Rectangle(90, 0, 15, 15), 2, false);
        }

        public ISprite CreateUpWalkingLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(60, 0, 15, 46);

            Texture2D upWalkingLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            upWalkingLink.SetData(data);
            return new AnimatedSprite(upWalkingLink, new Rectangle(0, 0, 15, 23), 2, false);
        }

        public ISprite CreateDownWalkingLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(0, 0, 15, 46);

            Texture2D leftWalkingLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            leftWalkingLink.SetData(data);
            return new AnimatedSprite(leftWalkingLink, new Rectangle(0, 0, 15, 23), 2, false);
        }

        public ISprite CreateLeftAttackingLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(24, 60, 28, 46);

            Texture2D leftAttackingLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            leftAttackingLink.SetData(data);
            return new AnimatedSprite(leftAttackingLink, new Rectangle(0, 0, 28, 23), 2, false);
        }

        public ISprite CreateRightAttackingLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(84, 60, 28, 46);

            Texture2D rightAttackingLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            rightAttackingLink.SetData(data);
            return new AnimatedSprite(rightAttackingLink, new Rectangle(0, 0, 28, 23), 2, false);
        }

        public ISprite CreateUpAttackingLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(60, 60, 18, 52);

            Texture2D upAttackingLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            upAttackingLink.SetData(data);
            return new AnimatedSprite(upAttackingLink, new Rectangle(0, 0, 18, 26), 2, false);
        }

        public ISprite CreateDownAttackingLinkSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(0, 0, 18, 52);

            Texture2D downAttackingLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            downAttackingLink.SetData(data);
            return new AnimatedSprite(downAttackingLink, new Rectangle(0, 0, 18, 26), 2, false);
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
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            Rectangle sourceRectangle = new Rectangle(61, 0, 14, 16);

            Texture2D upStillLink = new Texture2D(linkSpriteSheet.GraphicsDevice, sourceRectangle.Width, sourceRectangle.Height);
            Color[] data = new Color[sourceRectangle.Width * sourceRectangle.Height];
            linkSpriteSheet.GetData(0, sourceRectangle, data, 0, data.Length);
            upStillLink.SetData(data);
            return new Sprite(linkSpriteSheet, new Rectangle(0, 0, 14, 16));
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
