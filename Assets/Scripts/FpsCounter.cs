using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{
    public TextMeshProUGUI FPSCounterText;
    
    void Update()
    {
        //Framerate
        float frames = 1 / Time.unscaledDeltaTime;
        int fps = Mathf.RoundToInt(frames);
        FPSCounterText.text = "Frames Per Second:" + fps;
    }
}
