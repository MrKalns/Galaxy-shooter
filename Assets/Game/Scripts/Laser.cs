﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    [SerializeField]
    private float _speed = 10.0f;

	// Use this for initialization
	void Start () {
		
	}
    

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        if (transform.position.y > 6.1)
        {
            Destroy(this.gameObject);
        }
        

    }
}
