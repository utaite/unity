using UnityEngine;

public class Rotator : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        float v = 60 * Time.deltaTime;
        transform.Rotate(v, v, v);
    }
}
