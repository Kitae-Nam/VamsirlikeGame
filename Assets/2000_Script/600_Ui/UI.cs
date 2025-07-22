using UnityEngine;

public class UI : MonoBehaviour
{
    private void Start()
    {
        Intialize();
    }

    public void Intialize()
    {
        SetDebugController();

        Open();
    }
    public void Open()
    {

        Close();
    }
    public void Close()
    {

    }

    public static DebugController Debug {  get; private set; }

    private void SetDebugController()
    {
        Debug.GetComponentInChildren<DebugController>();
        Debug.Intialize();
    }
}
