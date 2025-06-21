using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scores;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Score.instance.AddScore(scores);
            Invoke("RemoveCoin", 0.2f);
        }
    }
    void RemoveCoin()
    {
        Destroy(gameObject);
    }
}

