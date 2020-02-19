using System.Collections.Generic;

namespace LegendOfZelda
{
    internal class ResetCommand : ICommand
    {
        private LegendOfZelda game;

        public ResetCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.enemyIndex = 0;
            game.enemies = GameSetup.GenerateEnemyList(game);
            game.itemIndex = 0;
            // don't need to make a new items list b/c they don't do as much

            game.link = new GreenLink(game);
            game.playerKeyboard = GameSetup.CreatePlayerKeysController(game.link);
            game.projectiles = new List<IProjectile>();
        }
    }
}
