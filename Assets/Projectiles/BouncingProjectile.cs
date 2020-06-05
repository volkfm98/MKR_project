using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingProjectile : MonoBehaviour
{
	[SerializeField] private GameObject m_Player;
	[SerializeField] private int m_count;

    // Start is called before the first frame update
    void Start()
    {	
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D col) {
        
        if (!col.gameObject.CompareTag("Player")) {
        	
        	// Debug.Log(m_count);
        	
        	if (m_count == 0)
        	{
	            this.transform.position -= (Vector3)this.GetComponent<Rigidbody2D>().velocity.normalized * 0.2f;


	            m_Player.GetComponent<CharacterController2D>().Teleport(this.transform);
	 
	            Destroy(gameObject);
        	}
        	else
        	{
        		m_count--;
        	}
        }
    }
}
