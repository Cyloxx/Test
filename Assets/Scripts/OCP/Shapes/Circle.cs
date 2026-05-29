using UnityEngine;

public class Circle : MonoBehaviour, IShape
{
    [SerializeField] private float radius;

    private void OnEnable() => ShapeRegistry.Register(this);
    private void OnDisable() => ShapeRegistry.Unregister(this);

    public float GetArea()
    {
        float area = Mathf.PI * radius * radius;
        //Debug.Log(area);
        return area;
    }
}
