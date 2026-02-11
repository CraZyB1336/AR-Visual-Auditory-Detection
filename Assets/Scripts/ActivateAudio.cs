using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ActivateAudio : MonoBehaviour
{
    [SerializeField]
    private GameObject audioCirclePrefab;

    private InputAction activate;

    void Start()
    {
        activate = InputSystem.actions.FindAction("Attack");
    }

    void Update()
    {
        if (activate.triggered)
        {
            SpawnAudioCircle();
        }
    }

    private void SpawnAudioCircle()
    {
        if (audioCirclePrefab != null)
        {
            GameObject audioCircle = Instantiate(audioCirclePrefab);
            audioCircle.transform.position = transform.position;
        }

        
    }
}
