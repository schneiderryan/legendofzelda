using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace LegendOfZelda
{
	class Merchant : NPC
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

		public override void Update()
		{
			sprite.Update();
		}

		public override void Draw(SpriteBatch spriteBatch, Color color)
		{
			sprite.Draw(spriteBatch, color);
		}
	}
}
