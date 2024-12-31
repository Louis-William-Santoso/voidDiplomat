using Godot;
using System;

public partial class homepage : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Godot.TextureButton newGameBtn = this.GetNode<Godot.TextureButton>("newGameBtn");
		Godot.TextureButton continueBtn = this.GetNode<Godot.TextureButton>("continueBtn");
		
	}
}
