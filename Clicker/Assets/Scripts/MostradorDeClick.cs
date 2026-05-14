using TMPro;
using UnityEngine;

public class MostradorDeClick : MonoBehaviour
{
    public TMP_Text porclick;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        porclick.text = "Por Click: " + Click.porClick;
        
    }
}
