using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlynthTrigger : MonoBehaviour
{
    public GameObject Spawn;

    [SerializeField] private GameObject Hammer;
    //private AudioSource source;

    void Start()
    {
        //source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Hammer)
        {
            //source.Play();
            Debug.Log("OBJECT DETECTED");
            Spawn.SetActive(false);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Hammer)
        {
            //source.Play();
            Debug.Log("Object Removed");
            Spawn.SetActive(true);
        }
    }
}

