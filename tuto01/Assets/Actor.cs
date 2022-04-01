using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor
{
    
    public string name;
    public string weapon;
    public int level;

    public string Talk()
    {
        return name + " talk something";
    }

    public string HasWeapon()
    {
        return (weapon);
    }

    public void    LevelUp()
    {
        level += level;
    }
}
