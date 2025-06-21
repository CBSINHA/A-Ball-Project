using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score instance;
    public Text scoreText;
    void Awake()
    {
        if (instance == null) instance = this;
    }
    int point=0;
    public void AddScore(int points)
    {
        point += points;
        scoreText.text = "Score: "+point.ToString();
    }
}
