using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Greenhorn", menuName = "Green Horn", order = 50)]
public class Adventurer : MonoBehaviour{

    public string Name;
    public string Title;
    public int Kills;
    public int Downed;
    public int Assist;
    public bool Dead;

    
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
