using Microsoft.Xna.Framework.Graphics;

public interface IEnemyState
{
	void Update();
    void MoveDown();
    void MoveUp();
    void MoveRight();
    void MoveLeft();
}
