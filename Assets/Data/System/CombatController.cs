using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    [HideInInspector] CameraController cameraController;

    void Awake()
    {
        cameraController = GetComponent<CameraController>();
    }

    public void InisiateCombat() {
        cameraController.SwitchCamera();
    }

}
