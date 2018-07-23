using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class player : MonoBehaviour {
    [Tooltip("in m/s")] [SerializeField] float xspeed = 4f;
    [Tooltip("in m/s")][SerializeField] float yspeed = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float yThrow = CrossPlatformInputManager.GetAxis("Vertical");
        float xoffset = xThrow * xspeed * Time.deltaTime;
        float yoffset = yThrow * yspeed * Time.deltaTime;
	}
}
