using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    public float num;
    public GameObject trigger;
    public AudioSource audioClip;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collider)
    {
            trigger.SetActive(true);
            audioClip.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
