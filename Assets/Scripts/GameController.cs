using UnityEngine;
using System.Collections;
using Assets.Scripts;


public class GameController : MonoBehaviour {
<<<<<<< HEAD
	public GameObject patient;
=======
	public  GameObject patient;
    private GameObject player;
    public Transform objectsPosition;
    public Transform patientPosition;
    private int level;
    private GameObject gameOverObject;

>>>>>>> 5e028e973a3ea5c7d2e88ea0ea2a4b5d9407d90e
	public float lifeTimePenalty;
    public Camera mainCamera;

    private int patientNum;
 
	// Use this for initialization
	void Start () {
<<<<<<< HEAD
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
=======
        player = GameObject.FindGameObjectWithTag("Player");
        level = 1;
        gameOverObject = GameObject.Find("GameOver");
        gameOverObject.SetActive(false);
        this.nextPatient();
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
>>>>>>> 5e028e973a3ea5c7d2e88ea0ea2a4b5d9407d90e
        }
	}

	private void nextPatient() {
<<<<<<< HEAD
        patient.GetComponent<Patient>().createPatient(patientNum);
=======
        player.transform.LookAt(objectsPosition);
        DiseaseGenerator.setDiseases(patient, level);
>>>>>>> 5e028e973a3ea5c7d2e88ea0ea2a4b5d9407d90e
	}

    public void gameOver() {
        gameOverObject.SetActive(true);
    }
}
