using StatePattern.MapObjects.SpatialCoordinates;

namespace StatePattern.MapObjects;

public abstract class MapObject
{
    protected Coordinate Coordinate = new();
    protected Map? Map { get; private set; }
    public void SetMap(Map map) => Map = map;
    protected virtual void RemoveMapObject()
    {
        Coordinate.RemoveCoordinate();
        Map!.RemoveMapObject(this);
    }
    public Coordinate GetCoordinate() => Coordinate;
    public Map GetMap() => Map!;
}