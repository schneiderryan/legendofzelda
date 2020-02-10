using Microsoft.Xna.Framework.Graphics;

public interface IAquamentusState
{
	void BreathFireball();
	void ChangeDirection();
	void BeKilled();
	void Update();
    void MoveDown();
    void MoveUp();
    void MoveRight();
    void MoveLeft();
}
