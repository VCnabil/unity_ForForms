using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omglol : MonoBehaviour
{
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        omg_i_made_aCube();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void omg_i_made_aCube()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 10, 0);
        Debug.Log("omg");
    }
}
