using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    public Child child;
    public float time = 300f;
    public Text remaining;
    [HideInInspector] public bool win = false; public bool loose = false;
    void Start()
    {
        if (instance == null) instance = this;
        remaining.text =((int)(time/60f)).ToString()+"m : "+((int)(time%60f)).ToString("00")+"s";
    }
    
    void Update()
    {
        if (time > 0f)
        {
            time -= Time.deltaTime;
            remaining.text = ((int)(time / 60f)).ToString() + "m : " + ((int)(time % 60f)).ToString("00") + "s";
            if (child.allcollected) win = true;
        }
        else loose = true;
    }
}
