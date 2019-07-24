using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Items{
    public int id;
    public string name;
    public string description; 
    public Sprite image;
    public Sprite icon;
    public List<Items> prereq = new List<Items>();


}