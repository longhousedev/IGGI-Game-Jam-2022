using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityCore
{

    namespace Audio
    {

        public class PlynthTrigger : MonoBehaviour
        {
            public Material Sky;
            public Material Night;
            public Material BloodMoon;
            public GameObject SpawnHouses;
            public GameObject ToggleTrees;
            public GameObject Flood;
            public GameObject GiantMushrooms;
            public GameObject Farms;
            public GameObject Libraries;
            public GameObject Castles;
            public GameObject MoreHouses;
            public GameObject RoadsCars;
            public GameObject Theatres;
            public GameObject Cafes;
            public GameObject Wizardtower;
            public GameObject Moarhooses;
            public GameObject Factory;
            public AudioController audioController;

            [SerializeField] private GameObject Skull;
            [SerializeField] private GameObject CrystalBall;
            [SerializeField] private GameObject Hammer;
            [SerializeField] private GameObject Axe;
            [SerializeField] private GameObject JarofWater;
            [SerializeField] private GameObject RedShroom;
            [SerializeField] private GameObject Sickle;
            [SerializeField] private GameObject Book;
            [SerializeField] private GameObject Sword;
            [SerializeField] private GameObject Mallet;
            [SerializeField] private GameObject Toycar;
            [SerializeField] private GameObject inkwelltheatre;
            [SerializeField] private GameObject Teapot;
            [SerializeField] private GameObject Wizardhat;
            [SerializeField] private GameObject Screwdriver;
            [SerializeField] private GameObject Cog;

            //private AudioSource source;

            void Start()
            {
                //source = GetComponent<AudioSource>();
            }

            private void OnTriggerEnter(Collider other)
            {
                if (other.gameObject == Hammer)
                {
                    //source.Play();
                    Debug.Log("Hammer DETECTED");
                    SpawnHouses.SetActive(true);
                    audioController.PlayAudio(AudioType.ST_01, true);
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
                if (other.gameObject == Sword)
                {
                    //source.Play();
                    Debug.Log("Sword DETECTED");
                    Castles.SetActive(true);
                }
                if (other.gameObject == Mallet)
                {
                    //source.Play();
                    Debug.Log("Mallet DETECTED");
                    MoreHouses.SetActive(true);
                }
                if (other.gameObject == Toycar)
                {
                    //source.Play();
                    Debug.Log("Toycar DETECTED");
                    RoadsCars.SetActive(true);
                }
                if (other.gameObject == inkwelltheatre)
                {
                    //source.Play();
                    Debug.Log("inkwelltheatre DETECTED");
                    Theatres.SetActive(true);
                }

                if (other.gameObject == Teapot)
                {
                    //source.Play();
                    Debug.Log("Teapot DETECTED");
                    Cafes.SetActive(true);
                }
                if (other.gameObject == Wizardhat)
                {
                    //source.Play();
                    Debug.Log("Wizardhat DETECTED");
                    Wizardtower.SetActive(true);
                }
                if (other.gameObject == Skull)
                {
                    RenderSettings.skybox = BloodMoon;
                }
                if (other.gameObject == CrystalBall)
                {
                    RenderSettings.skybox = Night;
                }


                if (other.gameObject == Screwdriver)
                {
                    //source.Play();
                    Debug.Log("Screwdriver DETECTED");
                    Moarhooses.SetActive(true);
                }

                if (other.gameObject == Cog)
                {
                    //source.Play();
                    Debug.Log("Cog DETECTED");
                    Factory.SetActive(true);
                }
            }
            private void OnTriggerExit(Collider other)
            {
                if (other.gameObject == Hammer)
                {
                    //source.Play();
                    Debug.Log("Hammer Removed");
                    SpawnHouses.SetActive(false);
                    audioController.StopAudio(AudioType.ST_01, true);
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
                if (other.gameObject == Sword)
                {
                    //source.Play();
                    Debug.Log("Sword Removed");
                    Castles.SetActive(false);
                }
                if (other.gameObject == Mallet)
                {
                    //source.Play();
                    Debug.Log("Mallet Removed");
                    MoreHouses.SetActive(false);
                }
                if (other.gameObject == Toycar)
                {
                    //source.Play();
                    Debug.Log("Toycar Removed");
                    RoadsCars.SetActive(false);
                }
                if (other.gameObject == inkwelltheatre)
                {
                    //source.Play();
                    Debug.Log("inkwelltheatre Removed");
                    Theatres.SetActive(false);
                }

                if (other.gameObject == Teapot)
                {
                    //source.Play();
                    Debug.Log("Teapot Removed");
                    Cafes.SetActive(false);
                }

                if (other.gameObject == Wizardhat)
                {
                    //source.Play();
                    Debug.Log("Wizardhat Removed");
                    Wizardtower.SetActive(false);
                }
                if (other.gameObject == Skull || other.gameObject == CrystalBall)
                {
                    RenderSettings.skybox = Sky;
                }
                if (other.gameObject == Screwdriver)
                {
                    //source.Play();
                    Debug.Log("Screwdriver Removed");
                    Moarhooses.SetActive(false);
                }
                if (other.gameObject == Cog)
                {
                    //source.Play();
                    Debug.Log("Cog Removed");
                    Factory.SetActive(false);
                }
            }
        }
    }
}

