using Cinemachine.PostFX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class VolumeSwapper : MonoBehaviour
{
    [SerializeField] VolumeProfile _profile;

    private void OnTriggerEnter(Collider other) 
    {
        // update with masks?
        CinemachineVolumeSettings volumeSettings = other.GetComponent<CinemachineVolumeSettings>();

        if(volumeSettings != null)
        {
            volumeSettings.m_Profile = _profile;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // update with masks?
        CinemachineVolumeSettings volumeSettings = other.GetComponent<CinemachineVolumeSettings>();

        if (volumeSettings != null)
        {
            volumeSettings.m_Profile = null;
        }
    }
}