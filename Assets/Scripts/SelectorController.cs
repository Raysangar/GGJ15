using UnityEngine;
using System.Collections;

public class SelectorController : MonoBehaviour {
    public GameObject patient;

    private ArrayList selectedMedicines;
    private int maxMedicines;

	// Use this for initialization
	void Start () {
        selectedMedicines = new ArrayList();        
	}

    void Awake()
    {
        setMaxMedicines();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Fire1"))
        {
            shootRay();            
        }
	}
    
    private void shootRay()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.gameObject.tag == "Medicine")
            {
                if (selectedMedicines.Count < maxMedicines)
                    selectedMedicines.Add(hitInfo.transform.gameObject);

                Debug.Log("Bucket : ");
                if (selectedMedicines.Count > 0)
                {
                    foreach (var med in selectedMedicines)
                    {
                        GameObject g = (GameObject)med;
                        Debug.Log(g.name + " ");
                    }
                }
            }
            if (hitInfo.transform.gameObject.tag == "Trash")
            {
                selectedMedicines.Clear();
            }
            
        }
    }

    private void setMedicine(GameObject unit)
    {        
        if (unit != null)
        {
            
        }
    }

    public void setMaxMedicines()
    {
        if (patient.GetComponent<Patient>().getCurrentDiseaseType() == "SimpleDisease")
        {
            maxMedicines = 1;
        }
        else
            maxMedicines = 2;
    }
}
