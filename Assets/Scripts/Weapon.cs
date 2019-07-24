using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon: Items{
    public Dictionary<string, int> stats = new Dictionary<string, int>();
    // min distance, max distance

    public Weapon(int id, string name, string description, Sprite image, Sprite icon, Dictionary<string, int> stats){
        this.id = id;
        this.name = name;
        this.description = description; 
        this.image = Resources.Load<Sprite>(""); //add path
        this.icon = Resources.Load<Sprite>(""); //add path
        this.stats = stats;


    }
    public Weapon(Weapon weapon){
        this.id = weapon.id;
        this.name = weapon.name;
        this.description = weapon.description; 
        this.image = Resources.Load<Sprite>(""); //add path
        this.icon = Resources.Load<Sprite>(""); //add path
        this.stats = weapon.stats;
    }
}
