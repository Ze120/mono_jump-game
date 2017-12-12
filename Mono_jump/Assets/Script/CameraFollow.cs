using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
	
	void LateUpdate () { //Use LateUpdate because we need camera follow our target a little bit slowly

        if (target.position.y > transform.position.y) {

            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }		
	}
}
