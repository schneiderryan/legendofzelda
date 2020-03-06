using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
	class Merchant : CollideableObject, INPC
	{
		private ISprite sprite;
		private Fire leftFire;
		private Fire rightFire;

		public Merchant(LegendOfZelda loz)
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

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch);
		}
	}
}