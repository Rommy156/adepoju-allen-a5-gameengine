using Godot;
using System;
using System.Diagnostics.Tracing;

public partial class SpawnLocation : Path2D
{	//add reference
	[Export] 
	CharacterBody2D Enemy;
	[Export]
	PackedScene EnemyPrefab;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{ 
	}
    public override void _Input(InputEvent @event)
    {
        if (Input.IsActionJustPressed("shoot")) 
		{
			PackedScene enemy = EnemyPrefab.Instantiate<PackedScene>();
			AddChild(Enemy);
        }
    }
}
