using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score;
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Player")
        {
            Score.instance.AddScore(score);
            Invoke("RemoveCoin", 0.2f);
        }
    }
    void RemoveCoin()
    {
        Destroy(this);
    }
}

