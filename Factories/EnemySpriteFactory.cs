using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class EnemySpriteFactory
    {
        private const int ANIMATION_DELAY = 8;
        private Texture2D enemySpriteSheet = Textures.GetEnemySheet();
        private Texture2D bossSpriteSheet = Textures.GetBossSheet();
        private Texture2D npcSpriteSheet = Textures.GetNPCSheet();
        private Texture2D miscSpriteSheet = Textures.GetMiscSheet();
        private Texture2D spawnSpriteSheet = Textures.GetWeaponSheet();
        private Texture2D merchantSpriteSheet = Textures.GetMerchantSheet();


        private EnemySpriteFactory() { }

        public static EnemySpriteFactory Instance { get; } = new EnemySpriteFactory();

        public ISprite CreateDeadEnemy()
        {
            return new AnimatedSprite(miscSpriteSheet, new Rectangle(102, 1, 15, 16), 2, true)
            { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateNewEnemy()
        {
            return new AnimatedSprite(spawnSpriteSheet, new Rectangle(135, 204, 15, 16), 2, true)
            { AnimationDelay = ANIMATION_DELAY };
        }
        public ISprite CreateDownMovingGoriyaSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 60, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateUpMovingGoriyaSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(60, 60, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateLeftMovingGoriyaSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 60, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateRightMovingGoriyaSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(90, 60, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateMovingGelSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(404, 186, 8, 9), 2, false);
        }

        public ISprite CreateMovingZolSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(381, 180, 15, 15), 2, false);
        }

        public ISprite CreateMovingTrapSprite()
        {
            return new Sprite(enemySpriteSheet, new Rectangle(270, 330, 16, 16));
        }

        public ISprite CreateMovingKeeseSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(235, 273, 16, 10), 2, true);
        }

        public ISprite CreateMovingStalfoSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(420, 120, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateMovingLFWallmasterSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateDraggingLFWallmasterSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(240, 0, 15, 15), 1, false)
            { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateMovingRFWallmasterSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 0, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateDraggingRFWallmasterSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(270, 0, 15, 15), 1, false)
            { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateMovingAquamentusSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(4, 0, 24, 32), 2, true)
                { AnimationDelay = 12 };
        }

        public ISprite CreateMovingFireAquamentusSprite()
        {
            return new AnimatedSprite(bossSpriteSheet, new Rectangle(94, 0, 24, 32), 2, true)
                { AnimationDelay = 12 };
        }

        public ISprite CreateDownMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 300, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateUpMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 300, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateLeftMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(0, 300, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
        }

        public ISprite CreateRightMovingSnakeSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(30, 300, 15, 15), 2, false)
                { AnimationDelay = ANIMATION_DELAY };
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
            return new Sprite(npcSpriteSheet, new Rectangle(231, 133, 26, 26))
            { Scale = 32f / 26f };
        }

        public ISprite CreateFireSprite()
        {
            return new AnimatedSprite(npcSpriteSheet, new Rectangle(103, 133, 26, 26), 2, true)
            {
                Scale = 32f / 26f,
                AnimationDelay = ANIMATION_DELAY
            };
        }

        public ISprite CreateMerchantSprite()
        {
            return new Sprite(merchantSpriteSheet, new Rectangle(0, 0, 15, 15));
        }


    }
}