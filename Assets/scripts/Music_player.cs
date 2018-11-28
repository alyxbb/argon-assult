using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_player : MonoBehaviour {

    private void Awake()
    {
        int noofmusicplayers = FindObjectsOfType<Music_player>().Length;
        if (noofmusicplayers > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
