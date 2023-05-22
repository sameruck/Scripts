using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class element : MonoBehaviour
{

    public Vector3[] myvert;
    public int[]     mytri;

    // Start is called before the first frame update
    void Start()
    {
        Vector3[] t_vert;

        t_vert = GetComponent<MeshFilter>().mesh.vertices;
        mytri  = GetComponent<MeshFilter>().mesh.triangles;

        for(int i = 0; i < t_vert.Length; i++){
            t_vert[i] = transform.TransformPoint(t_vert[i]);
        }
        myvert = t_vert;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3[] getvert(){
        return myvert;
    }  

    public int[] getTri(){
        return mytri;
    }
}
