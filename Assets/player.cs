using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class player : MonoBehaviour {
    [Tooltip("in m/s")] [SerializeField] float xspeed = 4f;
    [Tooltip("in m/s")][SerializeField] float yspeed = 4f;
    [Tooltip("in m")] [SerializeField] float xmin = -4.5f;
    [Tooltip("in m")] [SerializeField] float ymin = -3f;
    [Tooltip("in m")] [SerializeField] float xmax = 7.5f;
    [Tooltip("in m")] [SerializeField] float ymax = 2.5f;

    [SerializeField] float pitchfactor = -5f;
    [SerializeField] float yawfactor = 5f;
    [SerializeField] float throwpitchfactor = -10f;
    [SerializeField] float throwrollfactor = -20;
 
    float xThrow;
    float yThrow;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    { 
        Calculatemovement();
        Calculaterotation();
    }

    private void Calculatemovement()
    {
        xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        yThrow = CrossPlatformInputManager.GetAxis("Vertical");

        float xoffset = xThrow * xspeed * Time.deltaTime;
        float yoffset = yThrow * yspeed * Time.deltaTime;

        float rawxpos = transform.localPosition.x + xoffset;
        float rawypos = transform.localPosition.y + yoffset;

        float xpos = Mathf.Clamp(rawxpos, xmin, xmax);
        float ypos = Mathf.Clamp(rawypos, ymin, ymax);

        transform.localPosition = new Vector3(xpos, ypos, transform.localPosition.z);
    }
    private void Calculaterotation()
    {
    
        float ythrowtopitch = yThrow * throwpitchfactor;
        float ypostopitch = transform.localPosition.y * pitchfactor;
        float pitch = ypostopitch + ythrowtopitch;

        float yaw = transform.localPosition.x * yawfactor;
        float roll = xThrow * throwrollfactor;
        transform.localRotation = Quaternion.Euler(pitch,yaw,roll);
    }
}
