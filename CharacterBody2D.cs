using Godot;
using System;

public partial class CharacterBody2D : Godot.CharacterBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Godot.Sprite2D child = this.GetNode<Godot.Sprite2D>("MainCharacter/Sprite2D"); //Gets the child node
		float amount = 6;

		if (Input.IsKeyPressed(Key.W))
		{
			this.Position += new Vector2(0, -amount);
			//child.GlobalPosition = new Vector2(0,0); //To do something with the child
		}
		if (Input.IsKeyPressed(Key.S))
		{
			this.Position += new Vector2(0, amount);
		}
		if (Input.IsKeyPressed(Key.A))
		{
			this.Position += new Vector2(-amount, 0);
		}
		if (Input.IsKeyPressed(Key.D))
		{
			this.Position += new Vector2(amount, 0);
		}
	}
}
