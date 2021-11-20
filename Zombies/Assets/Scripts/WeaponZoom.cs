using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomeedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.5f;
    RigidbodyFirstPersonController FPcontroller;
    bool zoomedInToggle = false;
    public void Start()
    {
        FPcontroller = GetComponent<RigidbodyFirstPersonController>();
    }
    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                zoomedInToggle = true;
                fpsCamera.fieldOfView = zoomeedInFOV;
                FPcontroller.mouseLook.XSensitivity = zoomInSensitivity;
                FPcontroller.mouseLook.YSensitivity = zoomInSensitivity;

            }
            else
            {
                zoomedInToggle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                FPcontroller.mouseLook.XSensitivity = zoomOutSensitivity;
                FPcontroller.mouseLook.YSensitivity = zoomOutSensitivity;
            }

        }
    }
}
