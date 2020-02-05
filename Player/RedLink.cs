using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class RedLink : IPlayer 
    {
        public ISprite sprite;
        private KeyboardController keyboard;
        public ILinkState state;
        public int xPos;
        public int yPos;

        public RedLink()
        {
            this.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.sprite.Scale = 2.0f;
            this.xPos = 400;
            this.yPos = 200;
            this.sprite.Position = new Point(xPos, yPos);
            this.keyboard = new KeyboardController(generateDictionary());
            this.state = new StillUpRedLinkState(this);
        }

        public void MoveLeft()
        {
            state.MoveLeft();
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

        public void Attack()
        {
            state.Attack();
        }

        public void BeStill()
        {
            state.BeStill();
        }

        public void Update()
        {
            keyboard.Update();
            state.Update();
            sprite.Update();
        }

        public void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }

        private Dictionary<Keys, ICommand> generateDictionary()
        {
            Dictionary<Keys, ICommand> commands = new Dictionary<Keys, ICommand>();
            commands.Add(Keys.Left, new PlayerMoveLeftCommand(this));
            commands.Add(Keys.Right, new PlayerMoveRightCommand(this));
            commands.Add(Keys.Up, new PlayerMoveUpCommand(this));
            commands.Add(Keys.Down, new PlayerMoveDownCommand(this));
            commands.Add(Keys.A, new PlayerMoveLeftCommand(this));
            commands.Add(Keys.D, new PlayerMoveRightCommand(this));
            commands.Add(Keys.W, new PlayerMoveUpCommand(this));
            commands.Add(Keys.S, new PlayerMoveDownCommand(this));
            commands.Add(Keys.Z, new PlayerAttackCommand(this));
            commands.Add(Keys.N, new PlayerAttackCommand(this));
            commands.Add(Keys.None, new PlayerStillCommand(this));
            return commands;
        }
    }
}
