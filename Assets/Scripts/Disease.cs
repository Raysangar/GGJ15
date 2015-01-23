using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Disease : MonoBehaviour {

    public GameObject[] medicineList;

	// Use this for initialization
	void Start () {

	}

    public int heal(ArrayList medicines)
    {
        int works = 0;
        foreach (var medicine in medicines)
        {
            for(int i = 0; i < medicineList.Length; ++i){
                if (medicineList[i] == medicine)
                    ++works;
                else
                    --works;
            }
        }
        return works;
    }
}
