using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera InitCam = new CinemachineVirtualCamera();

    private CinemachineVirtualCamera currentCam;

    private void Start()
    {
        currentCam = InitCam;
        currentCam.enabled = true;
    }
    public void CameraSwitch(CinemachineVirtualCamera newCam)
    {
        currentCam.enabled = false;
        newCam.enabled = true;
        currentCam = newCam;
    }
}
