using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintbrush : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        // while the brush is showing, it'll paint the scene
        GetComponent<SpriteRenderer>().enabled = Input.GetMouseButton(0);

        // move to mouse
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;
        gameObject.transform.position = mousePos;
    }
}
