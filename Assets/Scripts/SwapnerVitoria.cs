using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapnerVitoria : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Modo "+Person.modo);
        Debug.Log("Vitoria"+Person.vitoria);
        GameObject playerInit = GameObject.Find("Spawner");
        Person.vitoria = Instantiate(Person.vitoria, playerInit.transform.position, playerInit.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
