using UnityEngine;

public class Child : MonoBehaviour
{
    public bool allcollected = false;

    void Update()
    {
        if (transform.childCount == 0 && !allcollected)
        {
            allcollected = true;
            Debug.Log("All coins collected!");
        }
    }
}
