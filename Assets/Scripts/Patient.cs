using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Patient : MonoBehaviour {
	private ArrayList diseases;
	
	public int heal (ArrayList medicines) {
		int diseaseHealed = (diseases [0] as GameObject).GetComponent<Disease> ().heal (medicines);
		if (diseaseHealed > 0) {
			(diseases [0] as GameObject).SetActive(false);
			diseases.RemoveAt(0);
		}
		return diseaseHealed;
	}

	public bool isHealthy() {
		return diseases.Count == 0;
	}

    public void setDiseases(ArrayList diseases)
    {
        this.diseases = diseases;
    }
}
