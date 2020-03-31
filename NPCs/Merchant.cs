using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
	class Merchant : CollideableObject, INPC
	{
		private ISprite sprite;

		public Merchant()
		{
			sprite = EnemySpriteFactory.Instance.CreateMerchantSprite();
			Hitbox = sprite.Box;
			X = 260;
			Y = 150;
			sprite.Position = new Point(X, Y);
		}

		public void Update()
		{
			sprite.Update();
		}

		public void Draw(SpriteBatch spriteBatch, Color color)
		{
			sprite.Draw(spriteBatch, color);
		}
	}
}
