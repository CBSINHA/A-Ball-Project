using UnityEngine;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public GameObject win;
    public GameObject lost;
    public GameObject restartButton;
    public GameObject HomeButton;
    AudioSource audioSource;
    public AudioClip loosemusic,winmusic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.instance.win == true) {audioSource.Stop();SoundManage.instance.playSound(winmusic) ; win.SetActive(true); restartButton.SetActive(true); HomeButton.SetActive(true); enabled = false; }
        if (Timer.instance.loose == true) { audioSource.Stop(); SoundManage.instance.playSound(loosemusic); lost.SetActive(true); restartButton.SetActive(true);HomeButton.SetActive(true); enabled = false; }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Home()
    {
        SceneManager.LoadScene("Intro");
    }
}
