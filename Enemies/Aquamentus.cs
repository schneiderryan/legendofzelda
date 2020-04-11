using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendOfZelda
{
	class Aquamentus : RandomMovingEnemy
	{
		public bool Breathed { get; set; }
		public LegendOfZelda game;

		public int CurrentStep => currentStep;
		
		public Aquamentus(LegendOfZelda game)
			: base(10)
		{
			this.game = game;
			Sprite = EnemySpriteFactory.Instance.CreateMovingAquamentusSprite();
			Hitbox = Sprite.Box;
			X = 400;
			Y = 200;
			Sprite.Position = new Point(X, Y);
			State = new LeftMovingAquamentusState(this);
			Breathed = false;
			currentHearts = 6;
			attackTimer = 100;
		}

		public override void Die()
		{
			//Sounds.GetBossDefeatedSound().Play();
			base.Die();
			foreach (KeyValuePair<String, IDoor> door in game.rooms[game.roomIndex].Doors.ToList())
			{
				if (door.Key == "right" && door.Value is RightOther)
				{
					Sounds.GetDoorUnlockSound().Play();
					game.rooms[game.roomIndex].Doors.Remove("right");
					game.rooms[game.roomIndex].Doors.Add("right", new RightOpen());
				}
			}
		}

	}
}
