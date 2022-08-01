using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using Unity.Profiling;
using TMPro;
using UnityEngine;

public class MemoryUsed : MonoBehaviour
{
    public TextMeshProUGUI MemoryUsedText;
    ProfilerRecorder MemoryUsedMemoryRecorder;

    private void OnEnable()
    {
        MemoryUsedMemoryRecorder = ProfilerRecorder.StartNew(ProfilerCategory.Memory, "Total Used Memory");
    }

    private void OnDisable()
    {
        MemoryUsedMemoryRecorder.Dispose();
    }

    private void Update()
    {
        var sb = new StringBuilder(500);
        if (MemoryUsedMemoryRecorder.Valid)
        {
            sb.AppendLine($"Total Used Memory: {MemoryUsedMemoryRecorder.LastValue / 1000000}");
        }
        MemoryUsedText.text = sb.ToString();
    }

}
