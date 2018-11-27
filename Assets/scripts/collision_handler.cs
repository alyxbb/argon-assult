using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision_handler : MonoBehaviour {

    [SerializeField] float levelloaddelay = 1f;
    [SerializeField] GameObject deathFX;
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
        deathFX.SetActive(true);
        Invoke("reloadscene", levelloaddelay);

    }

    private void reloadscene()
    {
        SceneManager.LoadScene(1);
    }

}
