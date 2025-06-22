using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 300f;
    public Text remaining;
    void Start()
    {
        remaining.text =(time/60f).ToString()+"m : "+Mathf.CeilToInt(time%60f).ToString("00")+"s";
    }

    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
            remaining.text =(time / 60f).ToString("0") + "m : " + (time % 60f).ToString("00") + "s";
        }
    }
}
