using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Sprint0;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{

	public class Goriya : IEnemy
	{
		public IGoriyaState state;
		public ISprite sprite;
		private KeyboardController keyboard;
		
		public Goriya()
		{

			this.sprite = EnemySpriteFactory.Instance.CreateDownMovingGoriyaSprite();
			this.sprite.Position = new Point(20, 20);
			this.keyboard = new KeyboardController(generateDictionary());
			this.state = new DownMovingGoriyaState(this);
		}

		public void ChangeDirection()
		{
			state.ChangeDirection();
		}

		public void BeKilled()
		{
			state.BeKilled();
		}

		public void MoveLeft()
		{
			state.MoveUp();
		}

		public void MoveRight()
		{
			state.MoveRight();
		}

		public void MoveUp()
		{
			state.MoveUp();
		}
		public void MoveDown()
		{
			state.MoveDown();
		}

		public void Update()
		{
			keyboard.Update();
			state.Update();
			sprite.Update();
		}

		public void Draw(SpriteBatch spriteBatch)
		{
			sprite.Draw(spriteBatch);
		}

		private Dictionary<Keys, ICommand> generateDictionary()
		{
			Dictionary<Keys, ICommand> commands = new Dictionary<Keys, ICommand>();
			commands.Add(Keys.U, new EnemyMoveUpCommand(this));
			commands.Add(Keys.D, new EnemyMoveDownCommand(this));
			return commands;
		}


	}
}