using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(
                transform.position.x + speed * Time.deltaTime,
                transform.position.y
            );
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(
                transform.position.x - speed * Time.deltaTime,
                transform.position.y
            );
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector2(
                transform.position.x,
                transform.position.y + speed * Time.deltaTime
            );
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector2(
                transform.position.x,
                transform.position.y - speed * Time.deltaTime
            );
        }
    }
}
