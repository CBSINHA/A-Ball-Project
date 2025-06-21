using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         
    }

    // Update is called once per frame
    public float speed;
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical) * speed * Time.deltaTime;
        rb.AddForce(movement,ForceMode.Impulse);
    }
}
