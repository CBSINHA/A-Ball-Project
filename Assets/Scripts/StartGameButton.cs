using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGameButton : MonoBehaviour
{
    public GameObject StartButton;
    [HideInInspector]public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
