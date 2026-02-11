using UnityEngine;

public class MicrophoneManager : MonoBehaviour
{
    public static MicrophoneManager instance;

    private static float micTriggerTime1 = -1.0f;
    private static float micTriggerTime2 = -1.0f;
    private static float micTriggerTime3 = -1.0f;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(this);
        }

        DontDestroyOnLoad(this);
    }

    public static void notifySignalDetected(int source)
    {
        float timeStamp = Time.realtimeSinceStartup;
        if (source == 1)
            micTriggerTime1 = timeStamp;
        if (source == 2)
            micTriggerTime2 = timeStamp;
        if (source == 3)
            micTriggerTime3 = timeStamp;

    }

}