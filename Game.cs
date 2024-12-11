using Godot;
using System;

public partial class Game : Node
{
    [Export]
    PackedScene enemyPrefab;
    [Export]
    Path2D spawn;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        RandomNumberGenerator random = new RandomNumberGenerator();
        Curve2D curve = spawn.Curve;
        Vector2 point = curve.Sample(0, random.RandfRange(0, 4));

        CharacterBody2D enemy = enemyPrefab.Instantiate<CharacterBody2D>();
        enemy.Position = point;
        AddChild(enemy);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (Area2D <Bullet> )

    }
}
