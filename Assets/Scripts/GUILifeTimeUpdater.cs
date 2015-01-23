using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUILifeTimeUpdater : MonoBehaviour {
    LifeTimer lifeTimer;
    Text lifeTimeText;

	// Use this for initialization
	void Start () {
        lifeTimeText = gameObject.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        lifeTimeText.text = lifeTimer.lifeTime.ToString();
	}

    public void newPatient(LifeTimer lifeTimer) {
        this.lifeTimer = lifeTimer;
    }
}
