using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speed;

    private float oldDirection;
    private bool moving;

	// Use this for initialization
	void Start () {        

        moving = false;

	}
	
	// Update is called once per frame
	void Update () {
                
        if (Input.GetKeyDown("space") && !moving){
            oldDirection = transform.rotation.eulerAngles.y;
            speed *= -1;
            moving = true;
        }
        if (moving)
        {
            float step = speed * Time.deltaTime;
            transform.Rotate(0f, step, 0f);
            Debug.Log(transform.rotation.eulerAngles.y - oldDirection);
            if ((speed < 0 && transform.rotation.eulerAngles.y - oldDirection < -90) 
                || (speed > 0 && transform.rotation.eulerAngles.y - oldDirection > 90))
                moving = false;
            
        }
        
	}
}
