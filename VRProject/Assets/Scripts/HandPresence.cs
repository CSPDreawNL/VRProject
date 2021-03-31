using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HandPresence : MonoBehaviour
{
    public bool showController = false;
    [SerializeField] InputDeviceCharacteristics m_controllerCharacteristics;
    [SerializeField] List<GameObject> m_controllerPrefabs;
    [SerializeField] GameObject m_handModelPrefab;

    InputDevice targetDevice;
    GameObject m_spawnedController;
    GameObject m_spawnedHandModel;

    // Start is called before the first frame update
    void Start()
    {
        var _devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(m_controllerCharacteristics, _devices);

        foreach (var item in _devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (_devices.Count > 0)
        {
            targetDevice = _devices[0];
            GameObject _prefab = m_controllerPrefabs.Find(controller => controller.name == targetDevice.name);

            if (_prefab)
                m_spawnedController = Instantiate(_prefab, transform);
            else
            {
                Debug.LogError("NO FUCKING CONTROLLER MODEL FOUND");
                m_spawnedController = Instantiate(m_controllerPrefabs[0], transform);
            }

            m_spawnedHandModel = Instantiate(m_handModelPrefab, transform);
        }
    }

    private void Update()
    {
        if (showController)
        {
            m_spawnedHandModel.SetActive(false);
            m_spawnedController.SetActive(true);
        }

        else
        {
            m_spawnedHandModel.SetActive(true);
            m_spawnedController.SetActive(false);
        }
    }
}
