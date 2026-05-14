using UnityEngine;
using TMPro;
public class Upgrade2 : MonoBehaviour
{
    public int observatorioEspacial = 2000;
    public int observatorioPorClick = 200;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnUpgrade2()
    {
        if (observatorioEspacial <= Mostrador.quantidade)
        {

            Click.porClick += observatorioPorClick;
            Mostrador.quantidade -= observatorioEspacial;
        }

        
    }
}
