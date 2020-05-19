using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpideyGun : Gun
{
    [SerializeField] private GameObject m_Projectile;
    [SerializeField] private float m_Force;

    private Rigidbody2D m_Rigidbody2D;

    public void Start() {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Fire() {
        GameObject projectile = Object.Instantiate(m_Projectile, this.transform);

        projectile.transform.position += new Vector3(0.3f, 0.0f, 0);

        projectile.SetActive(true);
        projectile.GetComponent<Rigidbody2D>().AddRelativeForce(new Vector2(m_Force, 0), ForceMode2D.Impulse);
        projectile.transform.parent = null;
    }
}
