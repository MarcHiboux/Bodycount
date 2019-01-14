﻿using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsManager : MonoBehaviour {

    public GameObject pcCreation;
    public Button pCButton;

    public InputField pCName;
    public InputField pCTitle;

    public GameObject greenHorn;

    public Transform adventurerTab;

    public GameObject statBlockManager;

    GameObject preFoetus;


    


    void Awake () {
        pcCreation.SetActive(false);
        statBlockManager.SetActive(false);
	}
	
	
	public void CreatePC() {
        pcCreation.SetActive(true);
        pCButton.GetComponent<Button>().interactable = false;
    }

    public void ConfirmCreation()
    {
        if (pCName.text != "")
        {

            pCButton.GetComponent<Button>().interactable = true;


            preFoetus = (GameObject)Instantiate(greenHorn, transform);

            preFoetus.name = pCName.ToString();

            GameObject tab = GameObject.Find("AdventurerTab");

            FadeToTab(tab);
            //Instantiate(greenHorn, transform);
            //greenHorn.transform.SetParent(adventurerTab);
            //greenHorn.GetComponentInChildren<Text>().text = pCName.ToString();


            
            pcCreation.SetActive(false);

            this.GetComponent<BraveAdventurer>().CreateFoetus();



            pCName.text = "";
            pCTitle.text = "";
        }
    }

    private void FadeToTab(GameObject tab)
    {
        greenHorn.transform.SetParent(tab.transform);
    }

    //public void ConfirmNewPC()
    //{
    //    if (pCName.text != "")
    //    {
    //        pcCreation.SetActive(false);
    //        pCButton.GetComponent<Button>().interactable = true;


    //        GameObject newPC = new GameObject(pCName.text);
    //        newPC.transform.SetParent(this.transform);
    //        Text myText = newPC.AddComponent<Text>();

    //        Font ArialFont = (Font)Resources.GetBuiltinResource(typeof(Font), "Arial.ttf");
    //        newPC.GetComponent<Text>().text = pCName.text;
    //        newPC.GetComponent<Text>().font = ArialFont;
    //        newPC.GetComponent<Text>().material = ArialFont.material;
    //    }
    //}
}
