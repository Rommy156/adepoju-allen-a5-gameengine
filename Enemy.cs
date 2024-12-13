using Godot;
using System;

public partial class Enemy : CharacterBody2D
{
    [Export]
    public float Speed;
    [Export]
    public CharacterBody2D character;


    public override void _Ready()
    {
        GD.Print(this);
    }

    public override void _PhysicsProcess(double delta)
    {
        Velocity = GlobalPosition.DirectionTo(character.GlobalPosition) * Speed;

        MoveAndSlide();
    }
}
