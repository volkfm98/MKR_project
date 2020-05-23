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

        Vector3 fireTrajectory = (this.transform.position - this.transform.parent.position).normalized;

        projectile.transform.parent = null;

        projectile.transform.position += fireTrajectory * -0.1f;
        projectile.transform.rotation = new Quaternion(0, 0, 0, 0);

        projectile.SetActive(true);
        projectile.GetComponent<Rigidbody2D>().AddRelativeForce(fireTrajectory * m_Force, ForceMode2D.Impulse);
    }
}
