using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class platform : MonoBehaviour
{

    float dirX;
    float speed = 3f;

    bool moveingUp = true;
 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 4f)
        {
            moveingUp = false;
        }
        else if (transform.position.y < -3.5f)
        {
            moveingUp = true;
        }
        if (moveingUp)
        {
            transform.position = new Vector2(transform.position.x , transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
