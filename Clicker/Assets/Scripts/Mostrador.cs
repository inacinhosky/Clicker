using TMPro;
using UnityEngine;

public class Mostrador : MonoBehaviour
{
    public static int quantidade;
    public TMP_Text display;
    public int quantidadeInterna;

    void Update()
    {
        quantidadeInterna = quantidade;
        display.text = "Quantidades:" + quantidadeInterna;
    }
}
