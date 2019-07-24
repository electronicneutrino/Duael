using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl2D : MonoBehaviour
{ // Start is called before the first frame update
   void Start()
   { 
       //QualitySettings.vSyncCount = 0;
       //Application.targetFrameRate = 10;
   }
   // Update is called once per frame
   void Update()
   {
       float horizontal = Input.GetAxis("Horizontal");
       float vertical = Input.GetAxis("Vertical");
       Vector2 position = transform.position;
       position.x = position.x + 1f * horizontal * Time.deltaTime;
       position.y = position.y + 1f * vertical * Time.deltaTime;
    //    position.Normalize();
       transform.position = position;
   }
}
