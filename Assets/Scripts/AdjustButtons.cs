using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustButtons : MonoBehaviour
{
    void OnGUI(){
        if (GUI.Button(new Rect(0, 0, 100, 30),"Press Me")){
            GameControl.control.health +=10;
        }
    }
}
