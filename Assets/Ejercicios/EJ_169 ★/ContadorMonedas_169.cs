using UnityEngine;

public class ContadorMonedas_169 : MonoBehaviour
{
    public int monedas = 0;
    public PlayerMove2D_169 movimiento;
    private bool ganado = false;

    public void SumarMoneda()
    {
        if (ganado) return;

        monedas = monedas + 1;

        if (monedas >= 3)
        {
            ganado = true;
            if (movimiento != null)
            {
                movimiento.enabled = false;
            }
            Debug.Log("VICTORIA");
        }
    }
}
