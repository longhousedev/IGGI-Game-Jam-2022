using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabber : MonoBehaviour
{

    private GameObject _grabbedObject;
    private GameObject _hands;
    private GameObject _player;
    private bool _isHeld;
    // Start is called before the first frame update
    void Start()
    {
        _isHeld = false;
        _hands = GameObject.FindWithTag("Hands");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && !_isHeld)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                if (hit.transform.CompareTag("Object"))
                {
                    _grabbedObject = hit.transform.gameObject;
                    hit.transform.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    _isHeld = true;
                }
            }
            
        }
        
        if (Input.GetKeyUp(KeyCode.E) && _isHeld)
        {
            _grabbedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
            _grabbedObject = null;
            _isHeld = false;
        }
    }

    private void FixedUpdate()
    {
        if (_isHeld)
        {
            _grabbedObject.transform.position = _hands.transform.position;
        }
    }
}
