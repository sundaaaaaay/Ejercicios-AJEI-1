using UnityEngine;

public class PatrullaPersecucion_167 : MonoBehaviour
{
    //points
    [SerializeField] private Transform pointA;
    [SerializeField] private Transform pointB;

    //player
    [SerializeField] private Transform player;

    //speed's
    [SerializeField] private float speedPatrulla = 2;
    [SerializeField] private float speedPersecucion = 3;
    [SerializeField] private float rango = 4;

    private Transform target;

    void Start()
    {
        target = pointA;
    }

    void Update()
    {
        float dist = Vector2.Distance(transform.position, player.position);

        if (dist < rango)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speedPersecucion * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speedPatrulla * Time.deltaTime);

            if (Vector2.Distance(transform.position, target.position) < 0.1f)
            {
                if (target == pointA)
                {
                    target = pointB;
                }
                else
                {
                    target = pointA;
                }
            }
        }
    }
}
