using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera dialogue;
    public Camera combat;

    void Awake() {
        dialogue.enabled = true;
        combat.enabled = false;
    }

    public void SwitchCamera() {
        dialogue.enabled = !dialogue.enabled;
        combat.enabled = !combat.enabled;
    }
}
