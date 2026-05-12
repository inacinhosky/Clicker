using UnityEngine;
using System.Collections;

public class Clickefeito : MonoBehaviour
{
    public float scaleDownFactor = 0.8f; 
    public float animationTime = 0.05f; 
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    public void OnClick()
    {
        StartCoroutine(ClickAnimation());
    }

    IEnumerator ClickAnimation()
    {
        
        transform.localScale = originalScale * scaleDownFactor;

        yield return new WaitForSeconds(animationTime);

        
        transform.localScale = originalScale;
    }
}
