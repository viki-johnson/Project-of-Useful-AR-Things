using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWindow : MonoBehaviour
{
    public Collider frame;
    public Animator window;
    // void Update() {
    //     float posX = Screen.width / 2f;
	//     float posY = Screen.height / 2f;
	//     Ray ray = Camera.main.ScreenPointToRay(new Vector3(posX, posY, 0));
	//     RaycastHit hit;

    //     if (Physics.Raycast(ray, out hit, 200)) {
	// 	    if(hit.collider == frame){
    //             window.SetTrigger("open");
    //         }
	//     }
    // }

    void Update() {
        // if ((Input.touchCount > 0) && (Input.GetTouch(0).phase == TouchPhase.Began)) {
        if(Input.GetMouseButtonDown(0)){
            // Ray raycast = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit)) {
                Debug.Log("Something Hit");
                if (raycastHit.collider == frame)
                {
                    Debug.Log("Soccer Ball clicked");
                    window.SetTrigger("open");
                }
            }
        }
    }
}
