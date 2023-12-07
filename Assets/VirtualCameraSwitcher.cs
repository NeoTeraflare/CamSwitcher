using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCameraSwitcher : MonoBehaviour {

    [SerializeField] private CinemachineVirtualCamera topCamera;
    [SerializeField] private CinemachineVirtualCamera isoCamera;

    private bool isoView;

    public void Start() {
        topCamera.m_Priority = 10;
        isoCamera.m_Priority = 20;
        isoView = true;
    }

    public void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isoView) {
                topCamera.m_Priority = 20;
                isoCamera.m_Priority = 10;
                isoView = false;
            } else {
                topCamera.m_Priority = 10;
                isoCamera.m_Priority = 20;
                isoView = true;
            }
        }
    }
}
