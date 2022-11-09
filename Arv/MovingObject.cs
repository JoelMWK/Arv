public class MovingObject : GameObject
{
    public Vector2 velocity { get; set; }

    public MovingObject()
    {
        velocity = new Vector2(5, 5);
    }
    public void Update()
    {
        pos.X += velocity.X;
        pos.Y += velocity.Y;
    }
}
