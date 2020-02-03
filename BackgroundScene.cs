using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Sprint0
{
    public class BackgroundScene : IScene
    {
        private SpriteFont font;
        private Vector2[] quads;
        private readonly float scale = 3.0f;
        private Vector2 origin;
        private IScene credits;
        private Texture2D lineTexture;
        private Rectangle horizontalLine;
        private Rectangle verticalLine;

        public BackgroundScene(SpriteFont font,  GraphicsDevice graphicsDevice)
        {
            Viewport viewport = graphicsDevice.Viewport;
            this.font = font;

           
            // Drawing lines: https://stackoverflow.com/a/4697364/8335309
            lineTexture = new Texture2D(graphicsDevice, 1, 1);
            lineTexture.SetData(new Color[] { Color.White });
            horizontalLine = new Rectangle(0, viewport.Height / 2 - 2, viewport.Width, 4);
            verticalLine = new Rectangle(viewport.Width / 2 - 2, 0, 4, viewport.Height);
        }

        public void Draw(SpriteBatch sb)
        {
            

           
        }
    }
}
