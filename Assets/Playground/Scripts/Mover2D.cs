using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Mover2D : MonoBehaviour
{
    [SerializeField] private float playerMovment = 5;
    [SerializeField] private float playerJump = 5;


    void Start()
    {
        
    }

    void Update()
    {

        Vector3 direction = new Vector3(0, 0);

        //wKey
        if (Keyboard.current.wKey.isPressed)
        {
            //Debug.Log("you pressed W");
            direction.y = 1;
        }

        //sKey
        if (Keyboard.current.sKey.isPressed)
        {
            //Debug.Log("you pressed S");
            direction.y = -1;
        }

        //aKey
        if (Keyboard.current.aKey.isPressed)
        {
            //Debug.Log("you pressed A");
            direction.x = -1;
        }


        //dKey
        if (Keyboard.current.dKey.isPressed)
        {
            //Debug.Log("you pressed D");
            direction.x = 1;
        }

        //jumpKey
        if (Keyboard.current.spaceKey.isPressed)
        {
        }

        transform.position = transform.position + direction * playerMovment * Time.deltaTime;
        //delta time makes it so the player keeps moving in the same speed regardless of their devices frame rate

        //transform.position -> Acceder a la posicion del objeto
        //z = 0

        // 1rst step: Read user input (as we read the users input we will be generating it) 
        // 2nd step: generate a direction
        // 3rd step: apply the movment 

    }
}
