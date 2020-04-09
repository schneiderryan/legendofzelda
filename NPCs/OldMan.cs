using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
	class OldMan : NPC
	{
		private ISprite sprite;

		public OldMan()
		{
			sprite = EnemySpriteFactory.Instance.CreateOldManSprite();
			Hitbox = sprite.Box;
			X = 240;
			Y = 130;
			sprite.Position = new Point(X, Y);
		}

		public override void Update()
		{
			sprite.Update();
		}

		public override  void Draw(SpriteBatch spriteBatch, Color color)
		{
			sprite.Draw(spriteBatch, color);
		}
	}
}
