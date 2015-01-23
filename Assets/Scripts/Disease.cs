using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Disease : MonoBehaviour {

    public ArrayList medicineList;

	// Use this for initialization
	void Start () {
        medicineList = new ArrayList();
	}

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
}
