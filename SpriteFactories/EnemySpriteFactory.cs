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
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 60, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingGoriyaSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(60, 60, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingGoriyaSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 60, 15, 15), 2, false);
        }

        public ISprite CreateRightMovingGoriyaSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(90, 60, 15, 15), 2, false);
        }


        public ISprite CreateMovingGelSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(400, 180, 14, 15), 2, false);
        }

        
        public ISprite CreateMovingTrapSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 330, 16, 16),1, false);
        }

        public ISprite CreateMovingKeeseSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 273, 16, 10), 2, true);
        }

        public ISprite CreateMovingStalfoSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false);
        }

        public ISprite CreateMovingLFWallmasterSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false);
        }

        public ISprite CreateMovingRFWallmasterSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 0, 15, 15), 2, false);
        }

        public ISprite CreateMovingAquamentusSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(4, 0, 24, 32), 2, true);
        }

        public ISprite CreateMovingFireAquamentusSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(94, 0, 24, 32), 2, true);
        }

        public ISprite CreateDownMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 300, 15, 15), 2, false);
        }

        public ISprite CreateUpMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 300, 15, 15), 2, false);
        }

        public ISprite CreateLeftMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 300, 15, 15), 2, false);
        }

        public ISprite CreateRightMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 300, 15, 15), 2, false);
        }

        public ISprite CreateDownMovingDodongoSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(0, 90, 16, 18), 2, false);
        }

        public ISprite CreateUpMovingDodongoSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(60, 90, 16, 18), 2, false);
        }

        public ISprite CreateLeftMovingDodongoSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(23, 90, 30, 18), 2, false);
        }

        public ISprite CreateRightMovingDodongoSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(83, 90, 30, 18), 2, false);
        }

        public ISprite CreateOldManSprite()
        {
            return new AnimatedSprite(npcSpriteSheet, new Rectangle(154, 134, 15, 15), 1, false);
        }

        public ISprite CreateFireSprite()
        {
            return new AnimatedSprite(npcSpriteSheet, new Rectangle(101, 134, 15, 15), 2, true);
        }
    }
}