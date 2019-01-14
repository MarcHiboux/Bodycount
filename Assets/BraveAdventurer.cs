using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

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
        backObject.name = name;
        backObject.GetComponentInChildren<Text>().text = name;

    }

    

}
