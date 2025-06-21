using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Ball;
    public Transform Position;
    public CameraFollow follow;
    void Start()
    {
        GameObject go= Instantiate(Ball, Position.position, Quaternion.identity);
        follow.ball = Ball.transform;
    }
}
