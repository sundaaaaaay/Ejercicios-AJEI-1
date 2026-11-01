using UnityEngine;

public class PatrullaPersecucion167 : MonoBehaviour
{
    [SerializeField] private Transform puntoA;
    [SerializeField] private Transform puntoB;
    [SerializeField] private Transform jugador;
    [SerializeField] private float speedPatrulla = 2;
    [SerializeField] private float speedPersecucion = 3;
    [SerializeField] private float rango = 4;

    private Transform target;

    void Start()
    {
        target = puntoA;
    }

    void Update()
    {
        float dist = Vector2.Distance(transform.position, jugador.position);

        if (dist < rango)
        {
            transform.position = Vector2.MoveTowards(transform.position, jugador.position, speedPersecucion * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speedPatrulla * Time.deltaTime);

            if (Vector2.Distance(transform.position, target.position) < 0.1f)
            {
                if (target == puntoA)
                {
                    target = puntoB;
                }
                else
                {
                    target = puntoA;
                }
            }
        }
    }
}
