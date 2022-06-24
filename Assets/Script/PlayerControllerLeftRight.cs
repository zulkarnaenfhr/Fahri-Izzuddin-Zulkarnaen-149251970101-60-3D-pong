using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerLeftRight : MonoBehaviour
{
    public int speed;
    public KeyCode moveLeftKey;
    public KeyCode moveRightKey;

  
    private void Start()
    {
       
    }

    void Update()
    {
        Vector2 movement = Vector2.zero;

        if (Input.GetKey(moveLeftKey))
        {
            movement = Vector2.left * speed;
        }
        if (Input.GetKey(moveRightKey))
        {
            movement = Vector2.right * speed;
        }

        transform.Translate(movement * Time.deltaTime);
    }
}
