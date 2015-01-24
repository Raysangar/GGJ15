using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUILifeTimeUpdater : MonoBehaviour {
    private LifeTimer lifeTimer;
    Text lifeTimeText;

	// Use this for initialization
	void Start () {
        lifeTimeText = gameObject.GetComponent<Text>();
        lifeTimer = GameObject.Find("GameController").GetComponent<LifeTimer>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        lifeTimeText.text = (lifeTimer.lifeTime >= 0) ? lifeTimer.lifeTime.ToString() : "0.0";
	}

    public void newPatient(LifeTimer lifeTimer) {
        this.lifeTimer = lifeTimer;
    }
}
