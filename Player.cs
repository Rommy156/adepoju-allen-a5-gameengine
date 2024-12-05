using Godot;
using System;

public partial class Player : CharacterBody2D
{
    [Export] public float speed = 200.0f;
    [Export] public float accel = 200.0f;

    public override void _PhysicsProcess(double delta)
	{

		// Get the input direction and handle the movement/deceleration.
		// As good practice, you should replace UI actions with custom gameplay actions.
		Vector2 direction = Input.GetVector("left", "right", "up", "down");
		direction = direction.Normalized();

		if (direction != Vector2.Zero)
		{
			Velocity = direction * speed;
		}
		else
		{
			Velocity = Velocity.MoveToward(Vector2.Zero, accel * (float)delta);
		}

		MoveAndSlide();
	}
}
