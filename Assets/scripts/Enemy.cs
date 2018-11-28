using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Addboxcollider();
        
	}

    private void Addboxcollider()
    {
        Collider boxcollider = gameObject.AddComponent<BoxCollider>();
        boxcollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
    
    void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
