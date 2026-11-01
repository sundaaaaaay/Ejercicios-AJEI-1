using UnityEngine;

public class Portal2D : MonoBehaviour
{
    [SerializeField] private Transform destino;

    void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.attachedRigidbody;
        if (rb == null) return;
        if (!rb.CompareTag("Player")) return;

        rb.position = destino.position;
        rb.linearVelocity = Vector2.zero;
    }
}
