using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public GameObject Cube;
    bool inf = true;
    public float speed = 5f;
    Vector3 move = new Vector3(0, -10, 0);

    // Update is called once per frame
    void Update()
    {
        while (inf == true)
        {
            Debug.Log("Step 1 - Get the Keys");
            inf = false;
            StartCoroutine(MoveCube());
            
        }
        Cube.transform.Translate(move * speed * Time.deltaTime);
    }

    public IEnumerator MoveCube()
    {
        Debug.Log("Step 2");
        if (move == new Vector3 (0, 10, 0))
        {
            move = new Vector3(0, -10, 0);
        }
        else if(move == new Vector3(0, -10, 0))
        {
            move = new Vector3(0, 10, 0);
        }
        yield return new WaitForSeconds(10);
        inf = true;
    }
}
