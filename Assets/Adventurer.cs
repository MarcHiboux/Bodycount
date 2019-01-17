using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(fileName = "Greenhorn", menuName = "Green Horn", order = 50)]

//Made a class for adventurer's stats. Name/titles are obviously strings. KDA are integers. Death is a bool.
public class Adventurer : MonoBehaviour
{

    public string Name;
    public string Title;
    public int Kills;
    public int Downed;
    public int Assist;
    public bool Dead;

    

    private void Awake()
    {
        GameObject tab = GameObject.Find("AdventurerTab");
    }

    public Adventurer() {
        Name = "";
        Title = "";
        Kills = 0;
        Downed = 0;
        Assist = 0;
        Dead = false;
    }

    public Adventurer(string Name, string Title, int Downed, int Assist, int Dead)
    {

    }
	
	
}
