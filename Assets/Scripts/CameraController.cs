using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public float speed;


    private float oldDirection;
    private bool moving;

<<<<<<< HEAD
=======


>>>>>>> 2829b384d680f1ba75b0bf933b11572f498e6212
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
            {
<<<<<<< HEAD
                if (briefRotation)
                {
                    startCountDown = true;
                    briefRotation = false;
                }
=======
>>>>>>> 2829b384d680f1ba75b0bf933b11572f498e6212
                moving = false;
            }
            
        }

<<<<<<< HEAD
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

=======

        
        
	}

>>>>>>> 2829b384d680f1ba75b0bf933b11572f498e6212
    public void SuccessRotation()
    {
        oldDirection = transform.rotation.eulerAngles.y;
        speed *= -1;
        moving = true;
    }

}
