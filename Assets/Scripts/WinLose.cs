using UnityEngine;

public class WinLose : MonoBehaviour
{
    public GameObject win;
    public GameObject lost;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.instance.win == true) { win.SetActive(true); enabled = false; }
        if (Timer.instance.loose == true) { lost.SetActive(true); enabled = false; }
    }
}
