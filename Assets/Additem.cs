using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;  
using System;
using UnityEngine.UI;
using System.Linq;
//using UnityEditor;


public class Additem : MonoBehaviour {

	public GameObject text;
public GameObject text1;
public GameObject text2;
public GameObject text3;
public GameObject text4;
public GameObject text5;
public GameObject text6;
public GameObject text7;


public GameObject[] salam;

public Text[] obez;

public InputField inputfieldname;

public Text first;
public Text first1;
public Text first2;
public Text first3;
public Text first4;
public Text first5;
public Text first6;
public Text first7;

public Text googy;



public Text input;

public int i=0;

void Start(){


obez = new Text[10];
salam = new GameObject[10];

obez[0] = first;
obez[1] = first1;
obez[2] = first2;
obez[3] = first3;
obez[4] = first4;
obez[5] = first5;
obez[6] = first6;
obez[7] = first7;

salam[0]= text;
salam[1]= text1;
salam[2]= text2;
salam[3]= text3;
salam[4]= text4;
salam[5]= text5;
salam[6]= text6;
salam[7]= text7;


}


public void show()
{



	
}

public int aeas=0;

public  void save(GameObject Ardo)
{

if (aeas==0)
{Ardo.SetActive(true);

aeas++;


	
}
else
{



string vesselam=";"+googy.text+"-";


for (int i = 0; i < 7; i++)
        {

if(salam[i].activeInHierarchy)
vesselam = vesselam + obez[i].text+",";


                    }


System.IO.File.AppendAllText(Application.persistentDataPath+"armando.txt", vesselam);

//System.IO.File.WriteAllText(Application.persistentDataPath+"armando.txt", "kelam");
//EditorUtility.DisplayDialog("Success", "Items Saved", "Ok");
Application.LoadLevel("main");

}}



public void Undo()
{



if(i!=0)
salam[i-1].SetActive(false);i--;

}




public void clearAll()
{

inputfieldname.Select();
inputfieldname.text="";


	while(i!=0)
	{

salam[i].SetActive(false);
--i;

	}
i++;
}


public void	buttonEvent()
	{
		



		//input.text = "AAG";
   
	obez[i].text = i + "." + input.text;

 
salam[i].SetActive(true);

inputfieldname.Select();
inputfieldname.text="";



i++;


}


}
