using UnityEngine;

public class Rectangle : MonoBehaviour, IShape
{
    [SerializeField] private float length;
    [SerializeField] private float height;

    private void OnEnable() => ShapeRegistry.Register(this);
    private void OnDisable() => ShapeRegistry.Unregister(this);

    public float GetArea()
    {
        float area = length * height;
        return area;
    }
}
