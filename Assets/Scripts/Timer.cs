using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float time = 300f;
    public Text remaining;
    void Start()
    {
        remaining.text = "Time: " + time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {

        }
    }
}
