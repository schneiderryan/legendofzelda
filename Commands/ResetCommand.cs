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
            /*game.enemyIndex = 0;

            game.enemies = GameSetup.GenerateEnemyList(game);*/

            //game.enemies = GameSetup.GenerateEnemyList();

            /*game.itemIndex = 0;*/
            // don't need to make a new items list b/c they don't do as much

            /*foreach(IPlayer player in game.players)
            {
                game.playerKeyboard = GameSetup.CreatePlayerKeysController(player);
            }*/
            //game.projectiles = new List<IProjectile>();
        }
    }
}
