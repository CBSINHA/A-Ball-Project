using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 distance;
    Transform ball;
    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position + distance;
    }
}
