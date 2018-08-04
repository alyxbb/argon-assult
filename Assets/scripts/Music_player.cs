using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_player : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
