using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speed;
    public float briefRotationTime;


    private float oldDirection;
    private bool moving;
    private bool briefRotation;
    private bool startCountDown;
    private float acumTime;

	// Use this for initialization
	void Start () {       
        moving = false;
        briefRotation = false;
        startCountDown = false;
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
            {
                if (briefRotation)
                {
                    startCountDown = true;
                    briefRotation = false;
                }
                moving = false;
            }
            
        }

        if (startCountDown)
        {
            acumTime += Time.deltaTime;
            if (acumTime > briefRotationTime)
            {
                oldDirection = transform.rotation.eulerAngles.y;
                speed *= -1;
                moving = true;
                startCountDown = false;
            }
        }
	}

    public void BriefRotation()
    {
        briefRotation = true;
    }

    public void SuccessRotation()
    {
        oldDirection = transform.rotation.eulerAngles.y;
        speed *= -1;
        moving = true;
    }

}
