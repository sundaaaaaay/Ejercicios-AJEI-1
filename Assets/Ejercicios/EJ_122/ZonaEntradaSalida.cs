using UnityEngine;

public class ZonaEntradaSalida : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            Debug.Log("Has entrado en " + gameObject.name);
        }
    }

    void OnTriggerExit2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            Debug.Log("Has salido de " + gameObject.name);
        }
    }
}
