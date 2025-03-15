using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button QuitButton;

    // Start is called before the first frame update
    void Start()
    {
        QuitButton.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick() {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
