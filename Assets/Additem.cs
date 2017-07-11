using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Additem : MonoBehaviour {

	public GameObject text;


public Text first;

public Text input;


public void	buttonEvent()
	{
		
		//input.text = "AAG";

		first.text = "1." + input.text;
 
text.SetActive(true);




}


}
