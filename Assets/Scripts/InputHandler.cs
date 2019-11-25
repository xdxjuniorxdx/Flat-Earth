using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour
{
   public GameObject[] players;

   void Awake() {
        players = GameObject.FindGameObjectsWithTag("Player");
        // Debug.Log("On InputHandler start:");
   }

   void Update() {
        // Player1 Controls   
        if (Input.GetKey("w")) {
            // Debug.Log("w");
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[0], null, (x, y)=>x.moveForward());  
        }
        if (Input.GetKeyUp("w")) {
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[0], null, (x, y)=>x.stop());
        }
        if (Input.GetKey("s")) {
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[0], null, (x, y)=>x.stop());
        }
        if (Input.GetKey("a")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[0], null, (x,y)=>x.turnLeft());  
        }        
        if (Input.GetKey("d")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[0], null, (x,y)=>x.turnRight());  
        }
        if (Input.GetKey("q")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[0], null, (x,y)=>x.push());  
        }
        if (Input.GetKey("e")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[0], null, (x,y)=>x.superPush());  
        }

        // Player2 Controls   
        if (Input.GetKey("i")){
            // Debug.Log("i");
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[1], null, (x, y)=>x.moveForward());  
        }
        if (Input.GetKeyUp("i")) {
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[1], null, (x, y)=>x.stop());
        }
        if (Input.GetKey("k")) {
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[1], null, (x, y)=>x.stop());
        }
        if (Input.GetKey("j")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[1], null, (x,y)=>x.turnLeft());  
        }        
        if (Input.GetKey("l")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[1], null, (x,y)=>x.turnRight());  
        }
        if (Input.GetKey("u")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[1], null, (x,y)=>x.push());  
        }
        if (Input.GetKey("o")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[1], null, (x,y)=>x.superPush());  
        }

        // Player3 Controls   
        if (Input.GetKey("t")){
            // Debug.Log("t");
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[2], null, (x, y)=>x.moveForward());  
        }
        if (Input.GetKeyUp("t")) {
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[2], null, (x, y)=>x.stop());
        }
        if (Input.GetKey("g")) {
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[2], null, (x, y)=>x.stop());
        }
        if (Input.GetKey("f")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[2], null, (x,y)=>x.turnLeft());  
        }        
        if (Input.GetKey("h")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[2], null, (x,y)=>x.turnRight());  
        }
        if (Input.GetKey("r")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[2], null, (x,y)=>x.push());  
        }
        if (Input.GetKey("y")){
            ExecuteEvents.Execute<InputTarget>(Person.playersSelect[2], null, (x,y)=>x.superPush());  
        }
   }
}