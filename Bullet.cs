using Godot;
using System;

public partial class Bullet : Node2D
{   //export speed settings
    [Export]
    float speed = 100f;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        TopLevel = true;
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {   
        float posX = Position.X + speed;
        Position = new Vector2(posX, Position.Y);
    }
}
