using UnityEngine;
using System.Collections;

public class Clickefeito : MonoBehaviour
{
    public float scaleDownFactor = 0.8f; // Quanto diminui
    public float animationTime = 0.05f; // Quão rápido
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
        // Diminui
        transform.localScale = originalScale * scaleDownFactor;

        yield return new WaitForSeconds(animationTime);

        // Volta ao tamanho original
        transform.localScale = originalScale;
    }
}
