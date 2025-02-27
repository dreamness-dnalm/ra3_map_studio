using Godot;
using System;
using ra3_map_studio.models;

public partial class MapTextureRect : TextureRect
{
	public Image showingImage;
	
	public override void _Ready()
	{
		showingImage = new Image();
	}

	public void Init()
	{
		this.Size = new Vector2(MapDataModel.MapWidth, MapDataModel.MapHeight);
	}
	
	public override void _Process(double delta)
	{
	}
}
