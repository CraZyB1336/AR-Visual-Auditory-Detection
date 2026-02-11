using UnityEngine;

public class Microphone : MonoBehaviour
{
    [SerializeField]
    private int id = 0;
    private double timeWhenSignalDetected = 0.0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 1. Hente collider
        // 2. Hente signal value
        // 3. Save the global time the signal event trigged
        timeWhenSignalDetected = Time.realtimeSinceStartup;

        MicrophoneManager.notifySignalDetected(id);

        // Use in microphone manager to calculate
        Debug.Log("Entered");
    }

    //private void OnTriggerStay2D()
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
