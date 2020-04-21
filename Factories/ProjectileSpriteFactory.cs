﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;


namespace LegendOfZelda
{
    class ProjectileSpriteFactory
    {
        private Texture2D projectileSpriteSheet = Textures.GetLinkSheet();
        private Texture2D enemySpriteSheet = Textures.GetEnemySheet();
        private static ProjectileSpriteFactory instance = new ProjectileSpriteFactory();

        private ProjectileSpriteFactory() { }

        public static ProjectileSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public ISprite CreateLeftArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(150, 199, 17, 6));
        }

        public ISprite CreateDownArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(124, 196, 6, 17));
        }

        public ISprite CreateRightArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(210, 199, 17, 6));
        }

        public ISprite CreateUpArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(185, 196, 6, 17));
        }

        public ISprite CreateRedLeftArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(150, 229, 17, 6));
        }

        public ISprite CreateRedDownArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(124, 224, 6, 17));
        }

        public ISprite CreateRedRightArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(210, 229, 17, 6));
        }

        public ISprite CreateRedUpArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(185, 224, 6, 17));
        }

        public ISprite CreateBlueLeftArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(150, 259, 17, 6));
        }

        public ISprite CreateBlueDownArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(124, 254, 6, 17));
        }

        public ISprite CreateBlueRightArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(210, 259, 17, 6));
        }

        public ISprite CreateBlueUpArrow()
        {
            return new Sprite(projectileSpriteSheet, new Rectangle(185, 254, 6, 17));
        }

        public ISprite CreateDownSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(4, 195, 7, 16), 2, false);
        }

        public ISprite CreateUpSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(64, 195, 7, 16), 2, false);
        }

        public ISprite CreateRightSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(90, 195, 16, 7), 2, false);
        }

        public ISprite CreateLeftSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(30, 195, 16, 7), 2, false);
        }

        public ISprite CreateBoomerang()
        {
            return new AnimatedSprite(Textures.GetWeaponSheet(),
                new Rectangle(63, 189, 8, 8), 8)
            {
                AnimationDelay = 3
            };
        }

        public ISprite CreateMovingFireballSprite()
        {
            return new AnimatedSprite(enemySpriteSheet, new Rectangle(334, 3, 8, 10), 3, true);
        }

    }
}
