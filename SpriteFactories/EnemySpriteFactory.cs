using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class EnemySpriteFactory
    {

       
        private Texture2D weaponsSpriteSheet;

        private Texture2D enemySpriteSheet = Textures.GetEnemySheet();
        private Texture2D bossSpriteSheet = Textures.GetBossSheet();

        private static EnemySpriteFactory instance = new EnemySpriteFactory();

        private EnemySpriteFactory() { }

        public static EnemySpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }


        public ISprite CreateDownMovingGoriyaSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image
            
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 60, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingGoriyaSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(60, 60, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingGoriyaSprite()
        {
           
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 60, 15, 15), 2, false);
        }

        public ISprite CreateRightMovingGoriyaSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(90, 60, 15, 15), 2, false);
        }


        public ISprite CreateMovingGelSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(400, 180, 14, 15), 2, false);
        }

        
        //334, 364, 3

        public ISprite CreateMovingTrapSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 330, 16, 16),1, false);
        }

        public ISprite CreateUpMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 273, 16, 10), 2, true);
        }

        public ISprite CreateDownMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 273, 16, 10), 2, true);
        }

        public ISprite CreateLeftMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 273, 16, 10), 2, true);
        }

        public ISprite CreateRightMovingKeeseSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 273, 16, 10), 2, true);
        }

        public ISprite CreateDownMovingStalfoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingStalfoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingStalfoSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false);
        }
        
        public ISprite CreateRightMovingStalfoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false);
        }

        public ISprite CreateDownMovingLFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingLFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingLFWallmasterSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false);
        }

        public ISprite CreateRightMovingLFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false);
        }

        public ISprite CreateDownMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingRFWallmasterSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false);
        }

        public ISprite CreateRightMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(271, 0, 15, 15), 2, false);
        }

        


        public ISprite CreateLeftMovingAquamentusSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(4, 0, 24, 32), 2, true);
        }

        public ISprite CreateRightMovingAquamentusSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(4, 0, 24, 32), 2,true);
        }

        public ISprite CreateLeftMovingFireAquamentusSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(94, 0, 24, 32), 2, true);
        }

        public ISprite CreateRightMovingFireAquamentusSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(94, 0, 24, 32), 2, true);
        }

        public ISprite CreateMovingFireballSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(329, 0, 16, 16), 3, true);
        }

        public ISprite CreateBoomerangSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(weaponsSpriteSheet, new Rectangle(64, 188, 7, 11), 2, true);
        }

    }
}