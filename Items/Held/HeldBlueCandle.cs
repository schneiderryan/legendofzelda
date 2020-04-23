using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
    class HeldBlueCandle : IHeldItem
    {
        public bool UsedInRoom { get; set; }
        public bool Found { get; set; }

        private ISprite sprite;

        public int X { get => sprite.X; set => sprite.X = value; }
        public int Y { get => sprite.Y; set => sprite.Y = value; }

        public HeldBlueCandle()
        {
            UsedInRoom = false;
            Found = false;
            sprite = ItemSpriteFactory.GetBlueCandle();
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }
    }
}
