using System.Collections.Generic;

public static class ShapeRegistry
{
    private static readonly List<IShape> _shapes = new();

    public static IReadOnlyList<IShape> Shapes => _shapes;

    public static void Register(IShape shape) => _shapes.Add(shape);
    public static void Unregister(IShape shape) => _shapes.Remove(shape);
}
