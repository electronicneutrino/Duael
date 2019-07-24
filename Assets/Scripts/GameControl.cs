using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl control;
    public float health; 
    public float experience;
    public Weapon weapon;
    public Defense defense; 
    public Ally ally;
    public Map map;

    void Awake(){
        if (control == null){
            control = this;
        } else if (control != this){
            Destroy(gameObject);
        }
    }

    void OnGUI(){
        GUI.Label(new Rect(10, 10, 100, 30), "Heath: " + health);
        GUI.Label(new Rect(10, 50, 100, 30), "Experience: " + experience);
        GUI.Label(new Rect(10, 90, 100, 30), "Weapon: " + weapon);
        GUI.Label(new Rect(10, 130, 100, 30), "Defense: " + defense);
        GUI.Label(new Rect(10, 170, 100, 30), "Ally: " + ally);
        GUI.Label(new Rect(10, 170, 100, 30), "Ally: " + map);


    }


}
