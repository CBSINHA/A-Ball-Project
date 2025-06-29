using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class WinLose : MonoBehaviour
{
    public GameObject win;
    public GameObject lost;
    public GameObject restartButton;
    public GameObject HomeButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.instance.win == true) { win.SetActive(true); restartButton.SetActive(true); HomeButton.SetActive(true); enabled = false; }
        if (Timer.instance.loose == true) { lost.SetActive(true); restartButton.SetActive(true);HomeButton.SetActive(true); enabled = false; }
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
