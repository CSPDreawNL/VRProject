using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class TennisBallSpawner : MonoBehaviour
{
    [SerializeField] GameObject m_tennisBallPrefab;
    [SerializeField] Transform m_shootingPoint;

    public void SpawnBall()
    {
        GameObject _ball = Instantiate(m_tennisBallPrefab, m_shootingPoint.position, transform.rotation);
    }
}
