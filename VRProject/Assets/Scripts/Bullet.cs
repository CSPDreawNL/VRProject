using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float m_lifeTime = 5;
    [SerializeField] bool m_isBullet;
    private void Start()
    {
        Destroy(gameObject, m_lifeTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (m_isBullet)
            Destroy(gameObject);
    }
}
