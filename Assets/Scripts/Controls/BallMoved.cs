using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoved : MonoBehaviour
{
    [SerializeField] private float _boucePower = 0f;

    private Vector3 force = default(Vector3);
    private Rigidbody _rbObj = default(Rigidbody);

    // Start is called before the first frame update
    void Start()
    {
        _rbObj = GetComponent<Rigidbody>();
        force = new Vector3(10.0f, 10.0f, 0.0f) * 100;
        
        _rbObj.AddForce(force);
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bar")
        {
            _rbObj.AddForce(0f,_boucePower,0f);   
        }
        Debug.Log("hit");
    }
}
