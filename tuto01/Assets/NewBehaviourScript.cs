using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    int mana = 20;
    
    void Start()
    {
        Debug.Log("tutorial unity");

        int level = 5;
        float strength = 15.5f;
        string playerName = "SwordMan";
        bool isFulllevel = false;
       
        Debug.Log("player name ?");
        Debug.Log(playerName);
        Debug.Log("Player Level ? ");
        Debug.Log(level);
        Debug.Log("Player strngth ?");
        Debug.Log(strength);
        Debug.Log("Player is FUll level? ?");
        Debug.Log(isFulllevel);

        string[] monsters = { "devil", "slime", "orc"};

        Debug.Log("monster in the map");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        List<string> items = new List<string>();
        items.Add("Life posion 30");
        items.Add("Mana posion 30");

        Debug.Log("items list");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        string title = "legend";
        Debug.Log("Player Name");
        Debug.Log(title + " " + playerName);

        string monsterAlam;
        switch (monsters[1])
        {
            case "devil":
                monsterAlam = "devil monster !";
                break;
            case "slime":
                monsterAlam = "slime monster !";
                break;
            default:
                monsterAlam = "Default monster !";
                break;
        }

        int health = 10;
        health = Heal(health);
        Debug.Log("Player hp ?");
        Debug.Log(health);
        Debug.Log("Player mana ?");
        Debug.Log(mana);

		Actor player = new Actor();
		player.name = "A";
		player.level = 2;
		player.weapon = "NICE SWORD";
		
		Debug.Log(player.name + " is new player");
		Debug.Log(player.level + " is player current lv");
		Debug.Log(player.name + " kill the monter " + monsters[0]);
		player.LevelUp();
		Debug.Log(player.name + " lv up !");
		Debug.Log(player.level + " is player current lv");

		player B = new player();

		B.name = "player B";	
		Debug.Log(B.move());
		Debug.Log(B.name);
		

	}

    int Heal(int num)
    {
        num += 10;
        mana += 20;
        Debug.Log("Player Healed 10p");
        return num;
    }
}
