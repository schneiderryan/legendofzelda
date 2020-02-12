using Microsoft.Xna.Framework;
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
    }
}
