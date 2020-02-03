using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
{
    class Link : IPlayer 
    {
        public ISprite sprite;
        private KeyboardController keyboard;
        public ILinkState state;
        public Link()
        {
            this.sprite = PlayerSpriteFactory.Instance.CreateUpStillLinkSprite();
            this.sprite.Position = new Point(20,20);
            this.keyboard = new KeyboardController(generateDictionary());
            this.state = new StillLinkState(this);
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

        private Dictionary<Keys, IPlayerCommand> generateDictionary()
        {
            Dictionary<Keys, IPlayerCommand> commands = new Dictionary<Keys, IPlayerCommand>();
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
