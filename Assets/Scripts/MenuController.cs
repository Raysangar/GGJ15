using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {
    public Animation fadeOut;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void startGame()
    {
        Application.LoadLevel(1);
    }

    private IEnumerator playFadeOutAnimation(int level){
        Debug.Log("fsafd");
        fadeOut.Play();
        Debug.Log("fsafd");
        yield return new WaitForSeconds(3);
        Debug.Log("carga");
        
    }

   public void showCredits() {
       Application.LoadLevel(2);
    }


}
