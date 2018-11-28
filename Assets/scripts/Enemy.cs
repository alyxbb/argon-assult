using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject deathfx;
    [SerializeField] Transform parent;
    
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
        GameObject fx = Instantiate(deathfx, transform.position, Quaternion.identity);
        fx.transform.parent = parent;

        Destroy(gameObject);
    }
}
