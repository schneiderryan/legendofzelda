using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LegendOfZelda;
using System;
using System.Collections.Generic;

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