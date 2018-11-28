using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCubes : MonoBehaviour {
    
    private GameObject holder; 
    private GameObject[] objArr = new GameObject[5];
    private Vector3 defPos = new Vector3 (0,0,0);
    private Vector3 scale = new Vector3(5, 5, 5);
    private float scaler = 1f;
    private int scaleDir = 0;
    // Current rotation
    float c_rot = 0;

    // Use this for initialization
    void Start () {
        holder = GameObject.Find("CubeHolder");
        defPos = holder.transform.localPosition;
        for (int i = 0; i < objArr.Length; i++) {
            objArr[i] = GameObject.CreatePrimitive(PrimitiveType.Cube);
            objArr[i].transform.localScale = scale;
            objArr[i].transform.localPosition = holder.transform.localPosition;
            objArr[i].transform.Rotate(i, i, 0);
        }
    }

    void Update () {
        
        if(scaleDir == 0)
        {
            scaler -= 0.01f;
        }
        else if (scaleDir == 1)
        {
            scaler += 0.03f;
        }

        if (scaler > 1.1f){
            scaler = 1.1f;
            scaleDir = 0;
        }
        else if (scaler < 0.5f)
        {
            scaler = 0.5f;
            scaleDir = 1;
        }

        c_rot += 0.05f;

        for (int i = 0; i < objArr.Length; i++) {
            objArr[i].transform.localPosition = new Vector3 (defPos.x+Mathf.Sin(c_rot)*2, defPos.y+Mathf.Cos(c_rot)*2, defPos.z);
            objArr[i].transform.Rotate((i+1)*0.1f, (i+1)*0.2f, (i+1)*0.3f);
            objArr[i].transform.localScale = Vector3.Scale(scale,Vector3.one*scaler);
        }

    }
}
