using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_handler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        startdeathsequence();
    }
    void startdeathsequence()
    {
        SendMessage("startdeathsequence");
    }

}
