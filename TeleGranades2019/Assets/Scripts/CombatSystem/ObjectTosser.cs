using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTosser : MonoBehaviour
{
    [SerializeField] private GameObject tossObject;
    [SerializeField] private Transform tossPoint;
    [SerializeField] private float tossSpeed;

    private Rigidbody tossObjectRBody;    


    private void Start()
    {        
        tossObjectRBody = tossObject.GetComponent<Rigidbody>();
        tossObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Toss(); 
        }
    }

    private void Toss()
    {
        tossObjectRBody.velocity = Vector3.zero;
        tossObject.transform.position = tossPoint.position;
        tossObject.transform.rotation = Quaternion.identity;
        tossObject.SetActive(true);
        tossObjectRBody.AddForce(tossPoint.transform.forward * tossSpeed, ForceMode.Impulse);
    }
}
