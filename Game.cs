using Godot;
using System;
using System.Drawing;

public partial class Game : Node
{  
    [Export]
    PackedScene enemyPrefab;
    [Export]
    Path2D spawn;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {   //store random value as variable
        RandomNumberGenerator random = new RandomNumberGenerator();
        //spawn path
        Curve2D curve = spawn.Curve;
        //a point in the path
        Vector2 point = curve.Sample(0, random.RandfRange(0, 4));
        //instantiate node to scene
        CharacterBody2D enemy = enemyPrefab.Instantiate<CharacterBody2D>();
        enemy.Position = point;
        //add child node
        AddChild(enemy);
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {

    }
}
