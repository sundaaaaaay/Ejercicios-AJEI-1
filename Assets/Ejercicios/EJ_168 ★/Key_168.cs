using UnityEngine;

public class Key_168 : MonoBehaviour
{
    public Puerta168 puerta;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            puerta.tieneLlave = true;
            gameObject.SetActive(false);
        }
    }
}
