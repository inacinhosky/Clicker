using UnityEngine;

public class Click : MonoBehaviour
{
    public static int porClick = 1;
    public void ClickBotao()
    {

        Mostrador.quantidade += porClick;
    }
}
