using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedPersonagens : MonoBehaviour
{

    public GameObject disco1, disco2, disco3, disco4;

    // Start is called before the first frame update
    void Start()
    {
        if(Person.playersSelect[0] != null){
            GameObject playerInit = GameObject.Find("Spawner1");
            Person.playersSelect[0] = Instantiate(Person.playersSelect[0], playerInit.transform.position, playerInit.transform.rotation);
            //disco1 = Instantiate(disco1, new Vector3(-0.018069f,0.0004f,0.101f) + playerInit.transform.position, playerInit.transform.rotation);
            //disco1.transform.parent = playerInit.transform;
        }
        if(Person.playersSelect[1] != null){
            GameObject playerInit = GameObject.Find("Spawner2");
            Person.playersSelect[1] = Instantiate(Person.playersSelect[1], playerInit.transform.position, playerInit.transform.rotation);
        }
        if(Person.playersSelect[2] != null){
            GameObject playerInit = GameObject.Find("Spawner3");
            Person.playersSelect[2] = Instantiate(Person.playersSelect[2], playerInit.transform.position, playerInit.transform.rotation);
        }
        if(Person.playersSelect[3] != null){
            GameObject playerInit = GameObject.Find("Spawner4");
            Person.playersSelect[3] = Instantiate(Person.playersSelect[3], playerInit.transform.position, playerInit.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
