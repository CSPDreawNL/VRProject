using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float m_lifeTime = 5;
    private void Start()
    {
        StartCoroutine(DestroyItself());
    }
    IEnumerator DestroyItself()
    {
        yield return new WaitForSeconds(m_lifeTime);
        Destroy(gameObject);
    }
}
