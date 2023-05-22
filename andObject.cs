using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andObject : MonoBehaviour
{

    public element[] element;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
        {
            calc();
        }
    }

    private void calc(){

        Vector3[] t_vert1;
        Vector3[] t_vert2;
        int[]     t_tri1;
        int[]     t_tri2;

        t_vert1 = element[0].getvert();
        t_vert2 = element[1].getvert();

        t_tri1 = element[0].getTri();
        t_tri2 = element[1].getTri();

    }

    //private float rayTriangleIntersect(){
    //  
    //} 
}
