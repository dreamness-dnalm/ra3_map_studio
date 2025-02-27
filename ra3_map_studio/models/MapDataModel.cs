namespace ra3_map_studio.models;

public static class MapDataModel
{
    public static int[][] HeightData { get; set; }

    private static int? _mapWidth = null;

    public static int MapWidth
    {
        get
        {
            _mapWidth ??= HeightData[0].Length;

            return _mapWidth.Value;
        }
    }
    
    private static int? _mapHeight = null;
    
    public static int MapHeight
    {
        get
        {
            _mapHeight ??= HeightData.Length;

            return _mapHeight.Value;
        }
    }
    
    
}