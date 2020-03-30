using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class PlayerSpriteFactory
    {
        private Texture2D linkSpriteSheet = Textures.GetLinkSheet();
        private Texture2D linkAttackingDown = Textures.GetLinkAttackingDown();
        private Texture2D linkAttackingUp = Textures.GetLinkAttackingUp();
        
        private static PlayerSpriteFactory instance = new PlayerSpriteFactory();

        private PlayerSpriteFactory() { }

        public static PlayerSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        //Green Link Sprites

        public ISprite CreateLeftWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(30, 0, 15, 16), 2, false);
        }

        public ISprite CreateRightWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(90, 0, 15, 16), 2, false);
        }

        public ISprite CreateUpWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(60, 0, 15, 16), 2, false);
        }

        public ISprite CreateDownWalkingLinkSprite()
        {
           return new AnimatedSprite(linkSpriteSheet, new Rectangle(0, 0, 15, 16), 2, false);
        }

        public ISprite CreateLeftAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkSpriteSheet, new Rectangle(24, 60, 28, 15), 2, false);
        }

        public ISprite CreateRightAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkSpriteSheet, new Rectangle(84, 60, 28, 15), 2, false);
        }

        

        public ISprite CreateUpAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkAttackingUp, new Rectangle(0, 0, 20, linkAttackingUp.Height), 2, true);
        }

        public ISprite CreateDownAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkAttackingDown, new Rectangle(0, 0, 17, linkAttackingDown.Height), 2, true);
        }

        public ISprite CreateLeftStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(30, 0, 15, 16));
        }

        public ISprite CreateRightStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(90, 0, 15, 16));
        }

        public ISprite CreateUpStillLinkSprite()
        {   
            return new Sprite(linkSpriteSheet, new Rectangle(60, 0, 15, 16));
        }

        public ISprite CreateDownStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(0, 0, 15, 16));
        }

        public ISprite CreateLeftProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(30, 60, 14, 14));
        }


        public ISprite CreateDownProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(0, 60, 15, 14));
        }

        public ISprite CreateUpProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(60, 60, 15, 15));
        }

        public ISprite CreateRightProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(90, 60, 14, 14));
        }

        // Red Link Sprites

        public ISprite CreateRedLeftWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(270, 0, 16, 16), 2, false);
        }

        public ISprite CreateRedRightWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(330, 0, 16, 16), 2, false);
        }

        public ISprite CreateRedUpWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(300, 0, 16, 16), 2, false);
        }

        public ISprite CreateRedDownWalkingLinkSprite()
        {
            return new AnimatedSprite(linkSpriteSheet, new Rectangle(240, 0, 16, 16), 2, false);
        }

        public ISprite CreateRedLeftAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkSpriteSheet, new Rectangle(258, 60, 27, 15), 2, false);
        }

        public ISprite CreateRedRightAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkSpriteSheet, new Rectangle(330, 60, 27, 15), 2, false);
        }

        public ISprite CreateRedUpAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkSpriteSheet, new Rectangle(390, 32, 16, 27), 2, false);
        }

        public ISprite CreateRedDownAttackingLinkSprite()
        {
            return new AnimateOnceSprite(linkSpriteSheet, new Rectangle(362, 32, 16, 27), 2, false);
        }

        public ISprite CreateRedLeftStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(270, 0, 16, 16));
        }

        public ISprite CreateRedRightStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(330, 0, 16, 16));
        }

        public ISprite CreateRedUpStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(300, 0, 14, 16));
        }

        public ISprite CreateRedDownStillLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(241, 0, 14, 16));
        }

        public ISprite CreateRedLeftProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(269, 60, 16, 16));
        }

        public ISprite CreateRedRightProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(330, 60, 16, 16));
        }

        public ISprite CreateRedUpProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(390, 43, 16, 16));
        }

        public ISprite CreateRedDownProjectileLinkSprite()
        {
            return new Sprite(linkSpriteSheet, new Rectangle(362, 32, 16, 16));
        }
    }
}
