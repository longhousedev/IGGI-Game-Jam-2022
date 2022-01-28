using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlynthTrigger : MonoBehaviour
{
    public GameObject SpawnHouses;
    public GameObject ToggleTrees;
    public GameObject Flood;
    public GameObject GiantMushrooms;
    public GameObject Farms;
    public GameObject Libraries;

    [SerializeField] private GameObject Hammer;
    [SerializeField] private GameObject Axe;
    [SerializeField] private GameObject JarofWater;
    [SerializeField] private GameObject RedShroom;
    [SerializeField] private GameObject Sickle;
    [SerializeField] private GameObject Book;

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
            Debug.Log("Hammer DETECTED");
            SpawnHouses.SetActive(true);
        }
        if (other.gameObject == Axe)
        {
            //source.Play();
            Debug.Log("Axe DETECTED");
            ToggleTrees.SetActive(false);
        }
        if (other.gameObject == JarofWater)
        {
            //source.Play();
            Debug.Log("JarofWater DETECTED");
            Flood.SetActive(true);
        }
        if (other.gameObject == RedShroom)
        {
            //source.Play();
            Debug.Log("RedShroom DETECTED");
            GiantMushrooms.SetActive(true);
        }
        if (other.gameObject == Sickle)
        {
            //source.Play();
            Debug.Log("Sickle DETECTED");
            Farms.SetActive(true);
        }
        if (other.gameObject == Book)
        {
            //source.Play();
            Debug.Log("Book DETECTED");
            Libraries.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject == Hammer)
        {
            //source.Play();
            Debug.Log("Hammer Removed");
            SpawnHouses.SetActive(false);
        }
        if (other.gameObject == Axe)
        {
            //source.Play();
            Debug.Log("Axe Removed");
            ToggleTrees.SetActive(true);
        }
        if (other.gameObject == JarofWater)
        {
            //source.Play();
            Debug.Log("JarofWater Removed");
            Flood.SetActive(false);
        }
        if (other.gameObject == RedShroom)
        {
            //source.Play();
            Debug.Log("RedShroom Removed");
            GiantMushrooms.SetActive(false);
        }
        if (other.gameObject == Sickle)
        {
            //source.Play();
            Debug.Log("Sickle Removed");
            Farms.SetActive(false);
        }
        if (other.gameObject == Book)
        {
            //source.Play();
            Debug.Log("Book Removed");
            Libraries.SetActive(false);
        }

    }
}

