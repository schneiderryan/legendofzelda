using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;


namespace LegendOfZelda
{
    static class GameSetup
    {
        public static IController CreatePlayerKeysController(IPlayer player)
        {
            KeyboardController controller = new KeyboardController();
            ICommand cmd;

            cmd = new PlayerMoveLeftCommand(player);
            controller.Register(Keys.Left, cmd);
            controller.Register(Keys.A, cmd);

            cmd = new PlayerMoveRightCommand(player);
            controller.Register(Keys.Right, cmd);
            controller.Register(Keys.D, cmd);

            cmd = new PlayerMoveUpCommand(player);
            controller.Register(Keys.Up, cmd);
            controller.Register(Keys.W, cmd);

            cmd = new PlayerMoveDownCommand(player);
            controller.Register(Keys.Down, cmd);
            controller.Register(Keys.S, cmd);

            cmd = new PlayerStillCommand(player);
            controller.Register(Keys.None, cmd);

            cmd = new PlayerAttackCommand(player);
            controller.Register(Keys.Z, cmd, KeyboardController.Priority.HIGH);
            controller.Register(Keys.N, cmd, KeyboardController.Priority.HIGH);

            cmd = new PlayerUseThrowingSwordCommand(player);
            controller.Register(Keys.D1, cmd, KeyboardController.Priority.HIGH);
            controller.Register(Keys.NumPad1, cmd, KeyboardController.Priority.HIGH);

            cmd = new PlayerUseArrowCommand(player);
            controller.Register(Keys.D2, cmd, KeyboardController.Priority.HIGH);
            controller.Register(Keys.NumPad2, cmd, KeyboardController.Priority.HIGH);

            cmd = new PlayerUseBoomerangCommand(player);
            controller.Register(Keys.D3, cmd, KeyboardController.Priority.HIGH);
            controller.Register(Keys.NumPad3, cmd, KeyboardController.Priority.HIGH);

            cmd = new PlayerUseBombCommand(player);
            controller.Register(Keys.D4, cmd, KeyboardController.Priority.HIGH);
            controller.Register(Keys.NumPad4, cmd, KeyboardController.Priority.HIGH);

            List<Keys> attackKeys = new List<Keys>()
            {
                Keys.Z,
                Keys.N
            };
            player.RegisterAttackKeys(attackKeys);

            return controller;
        }

        public static IController RoomController(LegendOfZelda game)
        {
            ICommand cmdRight = new SwapRoomCommand(game, "next");
            ICommand cmdLeft = new SwapRoomCommand(game, "previous");
            ICommand cmdUp = new SwapRoomCommand(game, "up");
            ICommand cmdDown = new SwapRoomCommand(game, "down");
            return new RoomController(game);
        }

        public static IController CreateGeneralKeysController(LegendOfZelda game)
        {
            KeyboardController controller = new KeyboardController();
            ICommand cmd;

            cmd = new ResetCommand(game);
            controller.Register(Keys.R, cmd);

            cmd = new QuitCommand(game);
            controller.Register(Keys.Q, cmd);

            cmd = new PauseGameCommand(game);
            controller.Register(Keys.P, cmd);

            return controller;
        }

        public static IList<IRoom> GenerateRoomList(LegendOfZelda game)
        {
            IList<IRoom> list = new List<IRoom>()
            {
                //new Room(game, "Rooms/TestLevel.csv"),
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
