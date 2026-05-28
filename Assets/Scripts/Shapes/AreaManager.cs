using UnityEngine;

public class AreaManager : MonoBehaviour
{
    void Start()
    {
        CalculateArea();
    }

    private void CalculateArea()
    {
        foreach (IShape shape in ShapeRegistry.Shapes)
        {
            shape.GetArea();
        }
    }
}