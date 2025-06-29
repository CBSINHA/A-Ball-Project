using UnityEngine;
public class HowtoPlayScript : MonoBehaviour
{
    public GameObject howtoplay;
    public GameObject instructions;
    [HideInInspector]public void InstructionManual()
    {
        instructions.SetActive(true);
    }
    [HideInInspector]public void CloseInstructionManual()
    {
        instructions.SetActive(false);
    }
}
