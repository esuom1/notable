using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        var d = Input.GetAxis("Mouse ScrollWheel");

        if (d > 0f)
        {
            cam.orthographicSize -= .1f;
        } else if (d < 0f)
        {
            cam.orthographicSize += .1f;
        }
    }
}
