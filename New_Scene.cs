using Godot;
using System;

public partial class New_Scene : Node2D
{
	PackedScene packedScene;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		packedScene = (PackedScene)GD.Load("res://Skull.tscn");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

    public override void _UnhandledInput(InputEvent @event)
    {
        if (@event is InputEventMouseButton mouseButton)
		{
			GD.Print("reached even callback");
			Sprite2D jitter = (Sprite2D)packedScene.Instantiate();
			jitter.Position = mouseButton.Position;
			this.AddChild(jitter);
		}
    }
}
