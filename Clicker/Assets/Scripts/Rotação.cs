using UnityEngine;
using UnityEngine.UIElements;

public class Rotação : MonoBehaviour
{
    public float velRotação = 24f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.FullScreenWindow);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, velRotação * Time.deltaTime);
    }
}
