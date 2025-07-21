#if Log

using System;
using UnityEditor.VersionControl;
using UnityEngine;
public enum LogType
{
    None = -1,

    AllLog = 0,

    StatHp,
    StatAtk,
    StatMoveSpeed,

    Max,
}

public class Log : MonoBehaviour
{
    public static void Message(LogType type, string message)
    {
        if (Manager.Log.LogOn[(int)LogType.AllLog] == false)
        {
            return;
        }

        if (Manager.Log.LogOn[(int)type] == false)
        {
            return;
        }

        string typeMessage = String.Empty;

        switch (type)
        {
            case LogType.StatAtk:
                {
                    typeMessage = $"[<Color=red>{type}</color>] ";
                }
                break;
            case LogType.StatMoveSpeed:
                {
                    typeMessage = $"[<Color=green>{type}</color>] ";
                }
                break;
        }

        Debug.Log(typeMessage + message);
    }
}
#endif