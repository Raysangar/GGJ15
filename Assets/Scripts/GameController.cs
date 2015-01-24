using UnityEngine;
using System.Collections;
using Assets.Scripts;


public class GameController : MonoBehaviour {

    public  GameObject patient;
    public Camera mainCamera;
    public float lifeTimePenalty;

    private GameObject gameOverObject;   

    private int patientNum;
 
	// Use this for initialization
	void Start () {

        patientNum = 1;
        gameOverObject = GameObject.Find("GameOver");
        gameOverObject.SetActive(false);
        this.nextPatient();
	}

    int getPatientNum()
    {
        return patientNum;
    }

	public void heal (ArrayList medicines) {
		int diseaseHealed = patient.GetComponent<Patient> ().heal (medicines);
		if (diseaseHealed < 0)
			GetComponent<LifeTimer> ().lifeTime -= lifeTimePenalty;
        else if (diseaseHealed > 0)
        {
            GetComponent<LifeTimer>().lifeTime += diseaseHealed + 1;
            if (patient.GetComponent<Patient> ().isHealthy())
                nextPatient();
        }
	}

	private void nextPatient() {

        patient.GetComponent<Patient>().createPatient(patientNum);

	}

    public void gameOver() {
        gameOverObject.SetActive(true);
    }
}
