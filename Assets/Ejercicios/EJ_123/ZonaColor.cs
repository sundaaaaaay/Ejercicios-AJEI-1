using UnityEngine;

public class ZonaColor : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GameObject.Find("Jugador").GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            sr.color = Color.red;
        }
    }

    void OnTriggerExit2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            sr.color = Color.white;
        }
    }
}
