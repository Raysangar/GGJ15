using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Desease : MonoBehaviour {

    public ArrayList medicineList;

	// Use this for initialization
	void Start () {
        medicineList = new ArrayList();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

<<<<<<< HEAD
	void heal(ArrayList medicines)  {
		
	}
=======
    public int heal(ArrayList medicines)
    {
        int works = 0;
        foreach (var medicine in medicines)
        {
            if (medicineList.Contains(medicine))
                ++works;
            else
                --works;
        }
        return works;
    }
>>>>>>> 89319fd70c317af55a698c73ac2ab9a3b50613f9
}
