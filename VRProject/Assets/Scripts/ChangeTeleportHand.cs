using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeTeleportHand : MonoBehaviour
{
    [SerializeField] XRController m_controller;

    private void Start()
    {
        m_controller = GetComponent<XRController>();
    }
    public void ChangeTeleporerHand()
    {
        switch(m_controller.controllerNode)
        {
            case XRNode.LeftHand:
                m_controller.controllerNode = XRNode.RightHand;
                break;
            case XRNode.RightHand:
                m_controller.controllerNode = XRNode.LeftHand;
                break;
        }
    }
}
