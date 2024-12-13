using Godot;
using System;

public partial class Bullet : Node2D
{   //export speed settings
    [Export]
    float speed = 500f;


    Vector2 targetPosition;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        TopLevel = true;

        targetPosition = GetViewport().GetMousePosition();
    }
        
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {   
        GlobalPosition += GlobalPosition.DirectionTo(targetPosition) * speed * (float)delta;
        
    }
}
