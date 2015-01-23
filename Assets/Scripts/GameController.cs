using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	GameObject patient;
	public float lifeTimePenalty;
	// Use this for initialization
	void Start () {
	
	}

	void heal (ArrayList medicines) {
		int diseaseHealed = patient.GetComponent<Patient> ().heal (medicines);
		if (diseaseHealed < 0)
			patient.GetComponent<LifeTimer> ().lifeTime -= lifeTimePenalty;
		else if (diseaseHealed > 0 && patient.GetComponent<Patient> ().isHealthy ())
			nextPatient ();
	}

	private void nextPatient() {
	}
}
