using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggler : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] Camera alternativeCamera;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F5))
        {
            mainCamera.enabled = !mainCamera.enabled;
            alternativeCamera.enabled = !alternativeCamera.enabled;
        }
    }
}
