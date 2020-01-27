using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class CreditsScene : IScene
    {
        private SpriteFont font;
        private readonly string credits = "Credits:\r\n"
                + "Program Made By: Isaac Smith\r\n"
                + "Sprites from:\r\nmariomayhem.com/downloads/sprites/smb1/smb_luigi_sheet.png\r\n"
                + "Font from: fonts.google.com/specimen/Press+Start+2P";
        private Vector2 position;

        public CreditsScene(SpriteFont font, Viewport viewport)
        {
            this.font = font;
            position = new Vector2(30, viewport.Height - 80);
        }

        public void Draw(SpriteBatch sb)
        {
            sb.DrawString(font, credits, position,
                    Color.LightCyan, 0, new Vector2(), 0.8f, SpriteEffects.None, 1);
        }
    }
}
