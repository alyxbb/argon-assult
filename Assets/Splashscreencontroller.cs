using UnityEngine;
using UnityEngine.SceneManagement;

public class Splashscreencontroller : MonoBehaviour {
    [SerializeField]int levelloadtime;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Startnextscenesequence();
	}

    private void Startnextscenesequence()
    {
        Invoke("Loadnextscene", levelloadtime);
    }
    private void Loadnextscene()
    {
        SceneManager.LoadScene(1);
    }
}
