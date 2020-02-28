using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    class EnemySpriteFactory
    {

        private Texture2D enemySpriteSheet = Textures.GetEnemySheet();
        private Texture2D bossSpriteSheet = Textures.GetBossSheet();
        private Texture2D npcSpriteSheet = Textures.GetNPCSheet();


        private EnemySpriteFactory() { }

        public static EnemySpriteFactory Instance { get; } = new EnemySpriteFactory();


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

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 0, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 0, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingRFWallmasterSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 0, 15, 15), 2, false);
        }

        public ISprite CreateRightMovingRFWallmasterSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 0, 15, 15), 2, false);
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

        public ISprite CreateDownMovingSnakeSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 300, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingSnakeSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 300, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingSnakeSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 300, 15, 15), 2, false);
        }

        public ISprite CreateRightMovingSnakeSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 300, 15, 15), 2, false);
        }

        public ISprite CreateDownMovingDodongoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(0, 90, 16, 18), 2, false);
        }

        public ISprite CreateUpMovingDodongoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(60, 90, 16, 18), 2, false);
        }

        public ISprite CreateLeftMovingDodongoSprite()
        {

            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(23, 90, 30, 18), 2, false);
        }

        public ISprite CreateRightMovingDodongoSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(bossSpriteSheet, new Rectangle(83, 90, 30, 18), 2, false);
        }

        public ISprite CreateOldManSprite()
        {
            //Crop spritesheet to contain only desired sprites
            //Help from https://gamedev.stackexchange.com/questions/35358/create-a-texture2d-from-larger-image

            return new AnimatedSprite(npcSpriteSheet, new Rectangle(154, 134, 20, 19), 1, false);
        }
    }
}