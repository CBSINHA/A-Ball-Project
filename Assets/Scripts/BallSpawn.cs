using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ball;
    public Transform Position;
    public CameraFollow follow;
    void Start()
    {
        GameObject go= Instantiate(ball, Position.position, Quaternion.identity);
        follow.ball = ball.transform;
    }
}
