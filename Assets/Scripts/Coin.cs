using UnityEngine;

public class Coin : MonoBehaviour
{
    public int scores;
    public AudioClip audioClip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Score.instance.AddScore(scores);
            SoundManage.instance.playSound(audioClip);
            Invoke("RemoveCoin", 0.3f);
        }
    }
    void RemoveCoin()
    {
        Destroy(gameObject);
    }
}

