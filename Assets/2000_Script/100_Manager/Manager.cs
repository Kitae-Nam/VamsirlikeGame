using UnityEngine;

public class Manager : MonoBehaviour
{
    private void Start()
    {
        Initialize();
    }
    void Initialize()
    {
        SetLogManager();
        SetDataManager();
    }

    public static LogManager Log { get; private set; }

    public void SetLogManager()
    {
        Log = transform.GetComponentInChildren<LogManager>();
    }

    public static DataManager Data { get; private set; }

    public void SetDataManager()
    {
        Data = transform.GetComponentInChildren<DataManager>();
    }

    public static StageManager Stage { get; private set; }

    
}
