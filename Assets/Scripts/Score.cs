using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static Score instance;
    public Text scoreText;
    void Awake()
    {
        scoreText.text = "Score: 0";
        if (instance == null) instance = this;
    }
    int point=0;
    public void AddScore(int points)
    {
        point += points;
        scoreText.text = "Score: "+point.ToString();
    }
}
