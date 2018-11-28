using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{

    GameObject cubeA; // The found object
    public GameObject cubeB; // Editor configured object

    void Start()
    {
        cubeA = GameObject.Find("Cube_A");
    }

    void Update()
    {
        // Rotate right (around the Y axis)
        cubeA.transform.Rotate(0, 1, 0);
        // Rotate left (around the Y axis)
        var angle = cubeB.transform.rotation.eulerAngles.y - 1;
        cubeB.transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
    }
}