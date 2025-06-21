using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ball;
    public Transform Position;
    void Start()
    {
        Instantiate(ball, Position.position, Quaternion.identity);
    }
}
