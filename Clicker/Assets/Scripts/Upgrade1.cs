using UnityEngine;
using TMPro;
public class Upgrade1 : MonoBehaviour
{
    public int casa = 10;
    public int casaPorClick = 2;
    public TMP_Text valorDaCasa;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnClick()
    {
        if (casa <= Mostrador.quantidade)
        {

            Click.porClick += casaPorClick;
            Mostrador.quantidade -= casa;
        }

        
    }
}
