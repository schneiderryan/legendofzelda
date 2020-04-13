using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace LegendOfZelda
{
    class Debug
    {
        public static void DrawHitbox(SpriteBatch sb, Rectangle hitbox)
        {
            DrawLine(sb, new Rectangle(hitbox.X, hitbox.Y, hitbox.Width, 1));
            DrawLine(sb, new Rectangle(hitbox.X, hitbox.Y + hitbox.Height, hitbox.Width, 1));
            DrawLine(sb, new Rectangle(hitbox.X, hitbox.Y, 1, hitbox.Height));
            DrawLine(sb, new Rectangle(hitbox.X + hitbox.Width, hitbox.Y, 1, hitbox.Height));
        }

        private static void DrawLine(SpriteBatch sb, Rectangle line)
        {
            sb.Draw(Textures.GetBlankTexture(),
                line,
                new Rectangle(1, 1, 1, 1),
                Color.White);
        }

        public static void WriteLine(object value)
        {
            System.Diagnostics.Debug.WriteLine(value);
        }
    }
}
