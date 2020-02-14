using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class RedLink : IPlayer 
    {
        public LegendOfZelda game;
        public ISprite sprite;
        private KeyboardController keyboard;
        public ILinkState state;
        public int xPos;
        public int yPos;
        private int item1Timer;

        public RedLink(LegendOfZelda game)
        {
            this.sprite = PlayerSpriteFactory.Instance.CreateRedUpStillLinkSprite();
            this.sprite.Scale = 2.0f;
            this.xPos = 400;
            this.yPos = 200;
            this.sprite.Position = new Point(xPos, yPos);
            this.keyboard = new KeyboardController(game, generateDictionary());
            this.state = new StillUpRedLinkState(this);
            this.game = game;
            this.item1Timer = 0;
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
            if(item1Timer > 0)
            {
                item1Timer--;
            }
        }

        public void Draw(SpriteBatch sb, Color color)
        {
            sprite.Draw(sb, color);
        }

        public void UseItem1()
        {
            if (item1Timer == 0)
            {
                item1Timer = 75;
                state.UseItem1();
            }
        }

        public void UseItem2()
        {
            //Implement item 2
        }

        public void UseItem3()
        {
            //Implement item 3
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
            commands.Add(Keys.E, new PlayerDamagedCommand(this));
            commands.Add(Keys.S, new PlayerMoveDownCommand(this));
            commands.Add(Keys.Z, new PlayerAttackCommand(this));
            commands.Add(Keys.N, new PlayerAttackCommand(this));
            commands.Add(Keys.None, new PlayerStillCommand(this));
            commands.Add(Keys.D1, new PlayerUseItem1Command(this));
            commands.Add(Keys.NumPad1, new PlayerUseItem1Command(this));
            commands.Add(Keys.D2, new PlayerUseItem2Command(this));
            commands.Add(Keys.NumPad2, new PlayerUseItem2Command(this));
            commands.Add(Keys.D3, new PlayerUseItem3Command(this));
            commands.Add(Keys.NumPad3, new PlayerUseItem3Command(this));
            return commands;
        }

        public void TakeDamage()
        {
            this.game.link = new DamagedLink(this, this.game);
        }
    }
}
