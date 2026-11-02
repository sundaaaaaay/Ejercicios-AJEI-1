using UnityEngine;

public class Moneda_169 : MonoBehaviour
{
    public ContadorMonedas_169 contador;
    private bool recogida = false;

    void OnTriggerEnter2D(Collider2D otro)
    {
        if (recogida) return;
        if (!otro.CompareTag("Jugador")) return;

        recogida = true;
        contador.SumarMoneda();
        gameObject.SetActive(false);
    }
}
