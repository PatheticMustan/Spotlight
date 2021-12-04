using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearWhenTheGameStarts : MonoBehaviour {
    void Start() {
        // to repaint the canvas, set the game object to active!
        gameObject.SetActive(false);
    }

    void FixedUpdate() {
        
    }
}