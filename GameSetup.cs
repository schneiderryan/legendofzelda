using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public static class GameSetup
    {
        public static IController CreatePlayerKeysController(IPlayer player)
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

            ICommand cmd = new PlayerMoveLeftCommand(player);
            keyBinds.Add(Keys.Left, cmd);
            keyBinds.Add(Keys.A, cmd);

            cmd = new PlayerMoveRightCommand(player);
            keyBinds.Add(Keys.Right, cmd);
            keyBinds.Add(Keys.D, cmd);

            cmd = new PlayerMoveUpCommand(player);
            keyBinds.Add(Keys.Up, cmd);
            keyBinds.Add(Keys.W, cmd);

            cmd = new PlayerMoveDownCommand(player);
            keyBinds.Add(Keys.Down, cmd);
            keyBinds.Add(Keys.S, cmd);

            cmd = new PlayerDamagedCommand(player);
            keyBinds.Add(Keys.E, cmd);

            cmd = new PlayerAttackCommand(player);
            keyBinds.Add(Keys.Z, cmd);
            keyBinds.Add(Keys.N, cmd);

            cmd = new PlayerUseThrowingSwordCommand(player);
            keyBinds.Add(Keys.D1, cmd);
            keyBinds.Add(Keys.NumPad1, cmd);

            cmd = new PlayerUseArrowCommand(player);
            keyBinds.Add(Keys.D2, cmd);
            keyBinds.Add(Keys.NumPad2, cmd);

            cmd = new PlayerUseBoomerangCommand(player);
            keyBinds.Add(Keys.D3, cmd);
            keyBinds.Add(Keys.NumPad3, cmd);

            cmd = new PlayerStillCommand(player);
            keyBinds.Add(Keys.None, cmd);

            List<Keys> attackKeys = new List<Keys>();
            attackKeys.Add(Keys.Z);
            attackKeys.Add(Keys.N);
            player.RegisterAttackKeys(attackKeys);

            return new KeyboardController(keyBinds);
        }

        public static IController CreateGeneralKeysController(LegendOfZelda game)
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

            ICommand cmd = new SwapItemCommand(game, "next");
            keyBinds.Add(Keys.I, cmd);

            cmd = new SwapItemCommand(game, "previous");
            keyBinds.Add(Keys.U, cmd);

            cmd = new ResetCommand(game);
            keyBinds.Add(Keys.R, cmd);

            cmd = new QuitCommand(game);
            keyBinds.Add(Keys.Q, cmd);

            return new SlowKeyboardController(keyBinds);
        }

        public static IController CreateEnemyKeysController(LegendOfZelda game)
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();
            return new EnemyKeyboardController(game, keyBinds);
        }

        public static List<IItem> GenerateItemList()
        {
            List<IItem> list = new List<IItem>()
            {
                new Arrow(),
                new BlueRupee(),
                new Bomb(),
                new Boomerang(),
                new Bow(),
                new Compass(),
                new Fairy(),
                new Heart(),
                new HeartContainer(),
                new Key(),
                new Map(),
                new Rupee(),
                new TriforceShard(),
                new WoodSword(),
            };

            foreach (IItem i in list)
            {
                i.X = 100;
                i.Y = 100;
            }


            return list;
        }

        public static List<IEnemy> GenerateEnemyList()
        {
            List<IEnemy> list = new List<IEnemy>()
            {
                new Gel(),
                new Aquamentus(),
                new Goriya(),
                new Keese(),
                new Stalfo(),
                new Trap(),
                new LFWallmaster(),
                new RFWallmaster(),
            };

            return list;
        }
    }
}
