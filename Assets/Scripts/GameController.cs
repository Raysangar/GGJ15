using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class GameController : MonoBehaviour {
	public  GameObject patient;
    private GameObject player;
    public Transform objectsPosition;
    public Transform patientPosition;
    private int level;
    private GameObject gameOverObject;

	public float lifeTimePenalty;
	// Use this for initialization
	void Start () {
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
        }
	}

	private void nextPatient() {
        player.transform.LookAt(objectsPosition);
        DiseaseGenerator.setDiseases(patient, level);
	}

    public void gameOver() {
        gameOverObject.SetActive(true);
    }
}
