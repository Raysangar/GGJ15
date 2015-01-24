using UnityEngine;
using System.Collections;

public class SelectorController : MonoBehaviour {
    private ArrayList units;
	// Use this for initialization
	void Start () {
        units = new ArrayList();
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
        Debug.Log("shoot");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(ray, out hitInfo))
        {
            if (hitInfo.transform.gameObject.layer.Equals(8))
                setUnit(hitInfo.transform.gameObject);
            else
                setUnit(null);
        }
    }

    private void setUnit(GameObject unit)
    {
        foreach (GameObject oldUnit in units)
            oldUnit.renderer.material.color = Color.white;
        units = new ArrayList();
        if (unit != null)
        {
            unit.renderer.material.color = Color.blue;
            units.Add(unit);
        }
    }
}
