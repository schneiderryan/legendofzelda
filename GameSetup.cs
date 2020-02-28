using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    static class GameSetup
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

            cmd = new PlayerUseBombCommand(player);
            keyBinds.Add(Keys.D4, cmd);
            keyBinds.Add(Keys.NumPad4, cmd);

            cmd = new PlayerStillCommand(player);
            keyBinds.Add(Keys.None, cmd);

            List<Keys> attackKeys = new List<Keys>()
            {
                Keys.Z,
                Keys.N
            };
            player.RegisterAttackKeys(attackKeys);

            return new KeyboardController(keyBinds);
        }

        public static IController CreateGeneralKeysController(LegendOfZelda game)
        {
            Dictionary<Keys, ICommand> keyBinds = new Dictionary<Keys, ICommand>();

            ICommand cmd;

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
                new Clock()
            };

            foreach (IItem i in list)
            {
                i.X = 100;
                i.Y = 100;
            }


            return list;
        }

        public static List<IEnemy> GenerateEnemyList(LegendOfZelda game)
        {
            List<IEnemy> list = new List<IEnemy>()
            {
                new Gel(),
                new Aquamentus(game),
                new Goriya(),
                new Keese(),
                new Stalfo(),
                new Trap(),
                new Snake(game),
                new LFWallmaster(),
                new RFWallmaster(),
                new Fireball()
            };

            return list;
        }

        public static List<Room> GenerateRoomList(LegendOfZelda game)
        {
            List<Room> list = new List<Room>()
            {
                new Room(game, "Rooms/TestLevel.csv"),
                new Room(game, "Rooms/Room0.csv"),
                new Room(game, "Rooms/Room1.csv"),
                new Room(game, "Rooms/Room2.csv"),
                new Room(game, "Rooms/Room3.csv"),
                new Room(game, "Rooms/Room4.csv"),
                new Room(game, "Rooms/Room5.csv"),
                new Room(game, "Rooms/Room6.csv"),
                new Room(game, "Rooms/Room7.csv"),
                new Room(game, "Rooms/Room8.csv"),
                new Room(game, "Rooms/Room9.csv"),
                new Room(game, "Rooms/Room10.csv"),
                new Room(game, "Rooms/Room11.csv"),
                new Room(game, "Rooms/Room12.csv"),
                new Room(game, "Rooms/Room13.csv"),
                new Room(game, "Rooms/Room14.csv"),
                new Room(game, "Rooms/Room15.csv"),
                new Room(game, "Rooms/Room16.csv"),
                new Room(game, "Rooms/Room17.csv"),
            };

            return list;
        }
    }
}
