using UnityEngine;
using System.Collections;

public class PanelSwitch : MonoBehaviour {

	// Use this for initialization

	private GameObject panel1 ;
	private GameObject panel2 ;

	void Start() { 
		panel1 = GameObject.Find("MainMenu"); 
		panel2 = GameObject.Find("GameSetting");
		NGUITools.SetActive(panel2,false);
	}  
	void OnClick() { 

		NGUITools.SetActive(panel2,true);
		NGUITools.SetActive(panel1,false);
	} 

	
	// Update is called once per frame
	void Update () {
	
	}

}
