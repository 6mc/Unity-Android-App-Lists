using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;  
using System;
using UnityEngine.UI;
using System.Linq;

public class init : MonoBehaviour {
public Text None;
public Text None1;
public Text None2;
public Text None3;
public Text None4;
public Text None5;
public Text None6;
public Text None7;
public Text None8;
public GameObject Element1;
public GameObject Element2;
public GameObject Element3;
public GameObject Element4;
public GameObject Element5;
public GameObject Element6;
public GameObject Element7;
public GameObject Element8;

public Text kruze;


public void create()
{



	System.IO.File.WriteAllText("armando.txt", "");
}


public void	denada()
	{GameObject[] ojb = new GameObject[50];
		Text[] txt = new Text[50];

txt[0]=None;
txt[1]=None1;
txt[2]=None2;
txt[3]=None3;
txt[4]=None4;
txt[5]=None5;
txt[6]=None6;
txt[7]=None7;
txt[8]=None8;

ojb[0]= Element1;	
ojb[1]= Element2;
ojb[2]= Element3;
ojb[3]= Element4;
ojb[4]= Element5;
ojb[5]= Element6;
ojb[6]= Element7;
ojb[7]= Element8;

for (int i = 0; i < 8; i++)
       {

ojb[i].SetActive(false);
                    }






		string text = System.IO.File.ReadAllText("armando.txt");

	
if(text=="")
None.text= "No List Found";


	else
	{
		

string[] lists = text.Split(';');

//string[] names= lists[0].Split('-');

//int a = lists

 for (int i = 0; i < lists.Count(); i++)
        {
                 string[] names= lists[i].Split('-');

                 if(i>0)
                 ojb[i-1].SetActive(true);

txt[i].text=names[0];

                    }


	}

}

	

public void show(int Seligman)
{

GameObject[] ojb = new GameObject[50];
		Text[] txt = new Text[50];

txt[0]=None;
txt[1]=None1;
txt[2]=None2;
txt[3]=None3;
txt[4]=None4;
txt[5]=None5;
txt[6]=None6;
txt[7]=None7;
txt[8]=None8;

ojb[0]= Element1;	
ojb[1]= Element2;
ojb[2]= Element3;
ojb[3]= Element4;
ojb[4]= Element5;
ojb[5]= Element6;
ojb[6]= Element7;
ojb[7]= Element8;



string taxt = System.IO.File.ReadAllText("armando.txt");


string[] lists = taxt.Split(';');

//for (int i = 0; i < lists.Count(); i++)
     //{
                 string[] names= lists[Seligman].Split('-');

                // if(i>0)
                // ojb[i-1].SetActive(true);

string[] titanic = names[1].Split(',');    


//for
 //  txt[0].text= titanic[0];             }
	
for (int a = 0; a < titanic.Count(); a++)
{

if(a!=0 && a!=1)
ojb[a-2].SetActive(true);
 
 txt[a].text= titanic[a]; 

}
}



public void Restart()
{




}

	// Use this for initialization
	void Start () {
		denada();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
