using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Patient : MonoBehaviour {

	private ArrayList diseaseList;
    private GameObject[] simpleDiseases;
    private GameObject[] complexDiseases;
    public int easyGameSimple, easyGameComplex, mediumGameSimple2, mediumGameSimpleComplex, mediumGameComplex2,
        hardGameSimple3, hardGameSimple2Complex1, hardGameSimple1Complex2, hardGameComplex3;

	// Use this for initialization
	void Start () {
        simpleDiseases = GameObject.FindGameObjectsWithTag("SimpleDisease");
        complexDiseases = GameObject.FindGameObjectsWithTag("ComplexDisease");
	}

	private ArrayList diseases;

	
	public int heal (ArrayList medicines) {
        int diseaseHealed = (diseaseList[0] as GameObject).GetComponent<Disease>().heal(medicines);
		if (diseaseHealed > 0) {
            (diseaseList[0] as GameObject).SetActive(false);
            diseaseList.RemoveAt(0);
		}
		return diseaseHealed;
	}

	public bool isHealthy() {
        return diseaseList.Count == 0;
	}


    public void createPatient(int numPatient)
    {
        simpleDiseases = GameObject.FindGameObjectsWithTag("SimpleDisease");
        complexDiseases = GameObject.FindGameObjectsWithTag("ComplexDisease");

        if (numPatient < easyGameSimple)
        {
            diseaseList.Add(simpleDiseases[Random.Range(0, simpleDiseases.Length)]);
        }
        else if (numPatient >= easyGameSimple && numPatient < easyGameComplex)
        {
            diseaseList.Add(complexDiseases[Random.Range(0, complexDiseases.Length)]);
        }
        else if (numPatient >= easyGameComplex && numPatient < mediumGameSimple2)
        {
            var number = Random.Range(0, simpleDiseases.Length);
            diseaseList.Add(simpleDiseases[number]);

            var number2 = Random.Range(0, simpleDiseases.Length);
            while (number2 == number)
                number2 = Random.Range(0, simpleDiseases.Length);

            diseaseList.Add(simpleDiseases[number2]);
        }
        else if (numPatient >= mediumGameSimple2 && numPatient < mediumGameSimpleComplex)
        {
            diseaseList.Add(simpleDiseases[Random.Range(0, simpleDiseases.Length)]);
            diseaseList.Add(complexDiseases[Random.Range(0, complexDiseases.Length)]);
        }
        else if (numPatient >= mediumGameSimpleComplex && numPatient < mediumGameComplex2)
        {
            var number = Random.Range(0, complexDiseases.Length);
            diseaseList.Add(complexDiseases[number]);

            var number2 = Random.Range(0, complexDiseases.Length);
            while (number2 == number)
                number2 = Random.Range(0, complexDiseases.Length);

            diseaseList.Add(complexDiseases[number2]);
        }
        else if (numPatient >= mediumGameComplex2 && numPatient < hardGameSimple3)
        {
            var number = Random.Range(0, simpleDiseases.Length);
            diseaseList.Add(simpleDiseases[number]);

            var number2 = Random.Range(0, simpleDiseases.Length);
            while (number2 == number)
                number2 = Random.Range(0, simpleDiseases.Length);

            diseaseList.Add(simpleDiseases[number2]);

            var number3 = Random.Range(0, simpleDiseases.Length);
            while (number3 == number || number3 == number2)
                number3 = Random.Range(0, simpleDiseases.Length);

            diseaseList.Add(simpleDiseases[number3]);
        }
        else if (numPatient >= hardGameSimple3 && numPatient < hardGameSimple2Complex1)
        {
            var number = Random.Range(0, simpleDiseases.Length);
            diseaseList.Add(simpleDiseases[number]);

            var number2 = Random.Range(0, simpleDiseases.Length);
            while (number2 == number)
                number2 = Random.Range(0, simpleDiseases.Length);

            diseaseList.Add(simpleDiseases[number2]);

            diseaseList.Add(complexDiseases[Random.Range(0, complexDiseases.Length)]);
        }
        else if (numPatient >= hardGameSimple2Complex1 && numPatient < hardGameSimple1Complex2)
        {
            diseaseList.Add(simpleDiseases[Random.Range(0, simpleDiseases.Length)]);

            var number = Random.Range(0, complexDiseases.Length);
            diseaseList.Add(complexDiseases[number]);

            var number2 = Random.Range(0, complexDiseases.Length);
            while (number2 == number)
                number2 = Random.Range(0, complexDiseases.Length);

            diseaseList.Add(complexDiseases[number2]);
        }
        else
        {
            var number = Random.Range(0, complexDiseases.Length);
            diseaseList.Add(complexDiseases[number]);

            var number2 = Random.Range(0, complexDiseases.Length);
            while (number2 == number)
                number2 = Random.Range(0, complexDiseases.Length);

            diseaseList.Add(complexDiseases[number2]);

            var number3 = Random.Range(0, complexDiseases.Length);
            while (number3 == number || number3 == number2)
                number3 = Random.Range(0, complexDiseases.Length);

            diseaseList.Add(complexDiseases[number3]);
        }
    }

    public void setDiseases(ArrayList diseases)
    {
        this.diseases = diseases;

    }
}
