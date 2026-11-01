using UnityEngine;

public class ZonaInvisible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            Debug.Log("Has entrado en la zona");
        }
    }
}
