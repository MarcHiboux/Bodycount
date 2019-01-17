using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;


// This script contains the function to create a new button to "host" an adventurer's data.
// The ButtonsManager has the function that calls this function.
public class BraveAdventurer : MonoBehaviour
{

    public GameObject greenHorn;

    public GameObject inputName;
    public GameObject inputTitle;

    public string name { get; set; }
    public string title { get; set; }

    GameObject backObject;

    public void CreateFoetus()
    {

        name = inputName.GetComponent<Text>().text.ToString();
        title = inputTitle.GetComponent<Text>().text.ToString();

        
        backObject = GameObject.Find("GreenHorn(Clone)"); 

        
        //backObject.GetComponentInChildren<Text>().text = name;

    }

    

}
