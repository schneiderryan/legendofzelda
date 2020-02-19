using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    public class Room : IRoom
    {
        private readonly Texture2D texture;
        protected Rectangle sourceRect;

        public Room(Texture2D texture, Rectangle sourecRect)
        {
            this.texture = texture;
            this.sourceRect = sourecRect;
   
        }

       
        public virtual void Draw(SpriteBatch sb)
        {
            this.Draw(sb);
        }

        public virtual void Update() { /* no code needed */ }
    }
}