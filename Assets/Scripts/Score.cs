using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    void Awake()
    {
        if (instance == null) instance = this;
    }
    int point=0;
    public void AddScore(int points)
    {
        point += points;
        Debug.Log(point);
    }
}
