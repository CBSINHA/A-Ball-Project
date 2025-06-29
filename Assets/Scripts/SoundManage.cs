using UnityEngine;

public class SoundManage : MonoBehaviour
{
    public static SoundManage instance;
    AudioSource audioSource;
    private void Awake()
    {
        if (instance == null) { instance = this;
            audioSource = GetComponent<AudioSource>();
        }
    }
    public void playSound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
