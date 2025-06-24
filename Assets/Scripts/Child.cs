using UnityEngine;

public class Child : MonoBehaviour
{
    int childcount;
    public bool allcollected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        childcount = transform.childCount;
    }
    // Update is called once per frame
    void Update()
    {
        if (childcount > transform.childCount)
        {
            childcount = transform.childCount;
        }
        if (childcount == 0)
        {
            allcollected = true;
        }
    }
}
