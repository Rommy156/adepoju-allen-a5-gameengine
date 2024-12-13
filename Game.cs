using Godot;

public partial class Game : Node
{  
    [Export]
    PackedScene enemyPrefab;
    [Export]
    Path2D spawn;
    [Export]
    CharacterBody2D character;
    [Export]
    Node2D enemies;
    
    //store random value as variable
    RandomNumberGenerator random = new RandomNumberGenerator();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        Spawn();
       
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
        if (Input.IsActionJustPressed("shoot")) 
        {
            Spawn();
        }
    }

    public void Spawn()
    {
        //spawn path
        Curve2D curve = spawn.Curve;
        //a point in the path
        Vector2 point = curve.Sample( random.RandiRange(0, 4),0);
        //instantiate node to scene
        CharacterBody2D enemy = enemyPrefab.Instantiate<CharacterBody2D>();
        enemy.Position =  point;
        //print spawn location cordinates
        GD.Print(point);
        //add child node

        enemy.Set("Speed", 100);
        enemy.Set("character", character);
        enemies.AddChild(enemy);
    }
}
