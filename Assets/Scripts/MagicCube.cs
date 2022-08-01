using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicCube : MonoBehaviour
{
    void Update()
    {
        MeshRenderer m = GetComponent<MeshRenderer>();
        m.material.SetFloat("movement", Time.realtimeSinceStartup);
    }
}
