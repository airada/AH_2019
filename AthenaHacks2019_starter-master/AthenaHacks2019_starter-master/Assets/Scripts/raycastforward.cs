using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastforward : MonoBehaviour
{
    public GameObject SpotLight;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
   
        float theDistance;

        //Debug Raycast in the Editor
        Vector3 forward = SpotLight.transform.rotation * Vector3.forward * 5;
        Debug.DrawRay(transform.position,forward, Color.green);

        if (Physics.Raycast(transform.position,(forward), out hit))
        {
            theDistance = hit.distance;
            print (theDistance + " " + hit.collider.gameObject.name);
        }
        
    }
}
