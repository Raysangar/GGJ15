using UnityEngine;
using System.Collections;

public class LifeTimer : MonoBehaviour {
	public float lifeTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime -= Time.deltaTime;
	}
}
