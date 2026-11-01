using UnityEngine;

public class Puerta168 : MonoBehaviour
{
    public bool tieneLlave = false;
    [SerializeField] private BoxCollider2D bloqueo;
    [SerializeField] private GameObject zonaAbrir;
//
    void OnTriggerEnter2D(Collider2D otro)
    {
        if (otro.CompareTag("Jugador"))
        {
            if (tieneLlave && bloqueo != null)
            {
                bloqueo.enabled = false;
                if (zonaAbrir != null)
                {
                    zonaAbrir.SetActive(false);
                }
            }
        }
    }
}