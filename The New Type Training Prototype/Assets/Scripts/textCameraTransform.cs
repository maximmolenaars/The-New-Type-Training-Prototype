using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textCameraTransform : MonoBehaviour {

    public Camera cameraToFollow;

	// Update is called once per frame
	void Update () {

        transform.LookAt(transform.position + cameraToFollow.transform.rotation * Vector3.zero,
                         cameraToFollow.transform.rotation * Vector3.down);
		
	}
}
