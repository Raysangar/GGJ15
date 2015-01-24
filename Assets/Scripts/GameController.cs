using UnityEngine;
using System.Collections;


public class GameController : MonoBehaviour {
	public GameObject patient;
	public float lifeTimePenalty;
    public Camera mainCamera;

    private int patientNum;
 
	// Use this for initialization
	void Start () {
        patientNum = 0;
	}

    int getPatientNum()
    {
        return patientNum;
    }

	void heal (ArrayList medicines) {
		int diseaseHealed = patient.GetComponent<Patient> ().heal (medicines);
		if (diseaseHealed < 0)
			patient.GetComponent<LifeTimer> ().lifeTime -= lifeTimePenalty;
        else if (diseaseHealed > 0 && patient.GetComponent<Patient>().isHealthy())
        {
            mainCamera.GetComponent<CameraController>().BriefRotation();
            nextPatient();
        }
	}

	private void nextPatient() {
        patient.GetComponent<Patient>().createPatient(patientNum);
	}
}
