using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicOrbs : MonoBehaviour
{
    public Transform ParentToOrbit;
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(ParentToOrbit.position, Vector3.up, speed * Time.deltaTime);
        MeshRenderer m = GetComponent<MeshRenderer>();
        m.material.SetFloat("movement", Time.realtimeSinceStartup);
        m.material.SetFloat("r", 5f);
    }
}
