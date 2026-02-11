using UnityEngine;

public class AudioGrower : MonoBehaviour
{
    [SerializeField]
    private float growSpeed = 2.0f;

    // Timer
    [SerializeField]
    private float maxLifeTime = 10.0f; // Seconds
    private float currentTime = 0.0f;

    //private float initialSignalValue = 10;
    //private float distance = 0.0f;

    void Update()
    {
        if (currentTime >= maxLifeTime)
        {
            Destroy(gameObject);
            return;
        }

        currentTime += Time.deltaTime;

        Vector3 currentScale = transform.localScale;
        currentScale.x += growSpeed * Time.deltaTime;
        currentScale.y += growSpeed * Time.deltaTime;

        transform.localScale = currentScale;

        //distance += growSpeed * Time.deltaTime;
        //signalValue = initialSignalValue / (distance*distance);
    }
}
