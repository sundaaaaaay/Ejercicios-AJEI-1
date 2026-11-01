using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove2D121 : MonoBehaviour
{
    [SerializeField] private float playerMovment = 5;
    private Rigidbody2D rb;

    void Start()
    {

    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 direction = Vector2.zero;

        //wKey
        if (Keyboard.current.wKey.isPressed)
        {
            direction.y = 1;
        }

        //sKey
        if (Keyboard.current.sKey.isPressed)
        {
            direction.y = -1;
        }

        //aKey
        if (Keyboard.current.aKey.isPressed)
        {
            direction.x = -1;
        }

        //dKey
        if (Keyboard.current.dKey.isPressed)
        {
            direction.x = 1;
        }

        rb.MovePosition(rb.position + direction * playerMovment * Time.fixedDeltaTime);
    }
}
