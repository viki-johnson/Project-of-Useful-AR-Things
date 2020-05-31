using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    public Collider frame;
    void Update() {
        float posX = Screen.width / 2f;
	    float posY = Screen.height / 2f;
	    Ray ray = Camera.main.ScreenPointToRay(new Vector3(posX, posY, 0));
	    RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 200)) {
		    if(hit.collider == frame){
                Debug.Log("hit frame");
            }
	    }
    }
}
