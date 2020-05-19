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

    private void OnCollisionEnter2D(Collision2D other) {
        m_Player.GetComponent<CharacterController2D>().Teleport(this.transform);
        Debug.Log(gameObject.name);
        Debug.Log("Saas");
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
