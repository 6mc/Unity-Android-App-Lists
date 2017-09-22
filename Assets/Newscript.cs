using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;  
using System;
using UnityEngine.UI;
using System.Linq;
//using UnityEditor;


public class Newscript : MonoBehaviour {
public Text arabam;

public void	Restart()
{
Application.LoadLevel(Application.loadedLevel);
	
}

public void	Carmela(){


Application.LoadLevel("erkk");
arabam.text="sogopo keja";

}

public void Cancel()
{

Application.LoadLevel("main");




}



}
