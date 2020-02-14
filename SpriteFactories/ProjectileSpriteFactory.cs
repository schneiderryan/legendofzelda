﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class ProjectileSpriteFactory
    {
        private Texture2D projectileSpriteSheet;
        private static ProjectileSpriteFactory instance = new ProjectileSpriteFactory();

        private ProjectileSpriteFactory() { }

        public static ProjectileSpriteFactory Instance
        {
            get
            {
                return instance;
            }
        }

        public void LoadTextures(ContentManager content)
        {
            projectileSpriteSheet = content.Load<Texture2D>("link");
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

        public ISprite CreateDownSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(4, 195, 7, 15), 4, false);
        }

        public ISprite CreateUpSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(64, 195, 7, 15), 4, false);
        }

        public ISprite CreateRightSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(90, 199, 16, 7), 4, false);
        }

        public ISprite CreateLeftSwordProjectile()
        {
            return new AnimatedSprite(projectileSpriteSheet, new Rectangle(30, 199, 16, 7), 4, false);
        }
    }
}
