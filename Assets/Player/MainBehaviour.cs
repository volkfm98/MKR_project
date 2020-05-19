using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBehaviour : MonoBehaviour
{
    Rigidbody2D m_rigidbody;
    Vector2 m_movement;

    public float m_MovementForce = 0.3f;

    //TODO: bool m_crouch;
    //TODO: bool m_jump;
    //TODO bool m_walk;
    
    // Start is called before the first frame update
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        m_movement.Set(horizontal, vertical);

        m_movement.Normalize();

        //vm_rigidbody.velocity =  m_movement * m_MovementForce;

        if (m_rigidbody.gravityScale != 0.0) {
           // m_rigidbody.AddForce(Physics.gravity * m_rigidbody.gravityScale * m_rigidbody.mass);
            Debug.Log(Physics.gravity * m_rigidbody.gravityScale * m_rigidbody.mass);
        }
    }
}
