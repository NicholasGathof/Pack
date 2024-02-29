using Godot;
using System;

public partial class main : Node2D
{
	// script connecting the play button
	private void _on_play_pressed()
	{
		// This changes the scene to the home sanctuary
		GetTree().ChangeSceneToFile("res://home.tscn");
	}
	
	// script connecting the quit button
	private void _on_quit_pressed()
	{
		// This just closes the game
		GetTree().Quit();
	}
}
