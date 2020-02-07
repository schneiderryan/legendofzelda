using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class EnemySpriteFactory
    {
        private Texture2D enemySpriteSheet;
        private static EnemySpriteFactory instance = new EnemySpriteFactory();

        private EnemySpriteFactory() { }

        public static EnemySpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public void LoadTextures(ContentManager content)
        {
            enemySpriteSheet = content.Load<Texture2D>("loz_enemy_sheet");
        }


        public ISprite CreateDownMovingGoriyaSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 60, 15, 15), 2, false, false);
        }

        public ISprite CreateUpMovingGoriyaSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(60, 60, 15, 15), 2, false, false);
        }

        public ISprite CreateLeftMovingGoriyaSprite()
        {
           
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 60, 15, 15), 2, false, false);
        }

        public ISprite CreateRightMovingGoriyaSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(90, 60, 15, 15), 2, false, false);
        }

        public ISprite CreateUpMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 270, 20, 15), 2, true, false);
        }

        public ISprite CreateDownMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 270, 20, 15), 2, true, false);
        }

        public ISprite CreateLeftMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 270, 20, 15), 2, true, false);
        }

        public ISprite CreateRightMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 270, 20, 15), 2, true, false);
        }

        public ISprite CreateDownMovingStalfoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false, true);
        }

        public ISprite CreateUpMovingStalfoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false, true);
        }

        public ISprite CreateLeftMovingStalfoSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false, true);
        }
        
        public ISprite CreateRightMovingStalfoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false, true);
        }

        public ISprite CreateDownMovingLFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false, false);
        }

        public ISprite CreateUpMovingLFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false, false);
        }

        public ISprite CreateLeftMovingLFWallmasterSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false, false);
        }

        public ISprite CreateRightMovingLFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false, false);
        }

        public ISprite CreateDownMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false, false);
        }

        public ISprite CreateUpMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false, false);
        }

        public ISprite CreateLeftMovingRFWallmasterSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false, false);
        }

        public ISprite CreateRightMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false, false);
        }


    }
}