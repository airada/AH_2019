using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchManager : MonoBehaviour
{

    public GameObject Spotlight;
   

    void Update()
    {
        if(Input.GetMouseButton(0))
        {

            Vector3 mousePosFar = new Vector3(Input.mousePosition.x,
                                               Input.mousePosition.y,
                                               Camera.main.farClipPlane);
            Vector3 mousePosNear = new Vector3(Input.mousePosition.x,
                                                Camera.main.nearClipPlane);
            Vector3 mousePosF = Camera.main.ScreenToWorldPoint(mousePosFar);
            Vector3 mousePosN = Camera.main.ScreenToWorldPoint(mousePosNear);

            //mousePosN is the ray starting position
            //mousePosF  - mousePosN is the direction
            Debug.DrawRay(mousePosN, mousePosF - mousePosN, Color.blue);


            RaycastHit hit;
            if(Physics.Raycast(mousePosN,mousePosF - mousePosN,out hit))
            {
                Spotlight.transform.rotation = Quaternion.LookRotation(mousePosF-mousePosN);
            }
        }
    }
}
