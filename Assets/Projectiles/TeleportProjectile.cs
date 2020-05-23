using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportProjectile : MonoBehaviour
{
    [SerializeField] private GameObject m_Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag != "Player") {
            this.transform.position -= (Vector3)this.GetComponent<Rigidbody2D>().velocity.normalized * 0.2f;

            m_Player.GetComponent<CharacterController2D>().Teleport(this.transform);
 
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
