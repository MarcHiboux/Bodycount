using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PushStatBlock : MonoBehaviour {

    public GameObject statBlock;

    public GameObject nameGoesHere;
    public GameObject titleGoesHere;

    public string nyme;
    public string title;

    public void Awake()
    {
        statBlock = GameObject.Find("Statblock");
        nameGoesHere = GameObject.Find("Adventurer name");
        titleGoesHere = GameObject.Find("Adventurer title");

        statBlock.SetActive(false);    
    
    }

    public void PushBlock() {

        
        nyme = this.gameObject.GetComponent<Adventurer>().Name.ToString();
        title = this.gameObject.GetComponent<Adventurer>().Title.ToString();
        
        nameGoesHere.gameObject.GetComponent<Text>().text = nyme;
        titleGoesHere.gameObject.GetComponent<Text>().text = title;

        statBlock.SetActive(true);
    }
}
