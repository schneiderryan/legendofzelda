using Microsoft.Xna.Framework;


namespace LegendOfZelda
{

	class RFWallmaster : RandomMovingEnemy
	{
		public RFWallmaster()
		{
			Sprite = EnemySpriteFactory.Instance.CreateMovingRFWallmasterSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new EnemyState(this);
			currentHearts = 1;
		}

	}
}