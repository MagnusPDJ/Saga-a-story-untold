using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Screenresdropdown : MonoBehaviour
{
    public int width=1920;
    public int height=1080;

    public void SetWidth(int newWidth) {
        width = newWidth;
    }

    public void SetHeight(int newHeight) {
        height = newHeight; 
    }

    public void SetRes() {
        Screen.SetResolution(width, height, false);
    }

   public void ScreenResDropdown(int index) {
        switch(index) {
            case 0:
                SetWidth(1280);
                SetHeight(720);
                SetRes(); break;
            case 1:
                SetWidth(1920);
                SetHeight(1080);
                SetRes(); break;
            case 2:
                SetWidth(2560);
                SetHeight(1440);
                SetRes(); break;
        }
    }
}
