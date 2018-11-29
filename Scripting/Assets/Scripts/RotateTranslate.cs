using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTranslate : MonoBehaviour
{
    public Vector3 translateAmt = Vector3.zero;
    [SerializeField] Vector3 rotateAmt = Vector3.zero;

    [SerializeField]
    [Range(0f, 1f)]
    float scaler = .5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(rotateAmt);
        transform.Translate(translateAmt * Time.deltaTime * scaler);

    }

}
