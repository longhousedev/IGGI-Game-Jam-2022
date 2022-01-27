using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlynthTrigger : MonoBehaviour
{
    public GameObject SpawnHouses;
    public GameObject ToggleTrees;

    [SerializeField] private GameObject Hammer;
    [SerializeField] private GameObject Axe;
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
            SpawnHouses.SetActive(true);
        }
        if (other.gameObject == Axe)
        {
            //source.Play();
            Debug.Log("OBJECT DETECTED");
            ToggleTrees.SetActive(false);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Hammer)
        {
            //source.Play();
            Debug.Log("Object Removed");
            SpawnHouses.SetActive(false);
        }
        if (other.gameObject == Axe)
        {
            //source.Play();
            Debug.Log("Object Removed");
            ToggleTrees.SetActive(true);
        }
    }
}

