using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public int u;
    private int cont = 0;

    void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {       

            u = other.gameObject.GetComponent<BasicCharControl>().player_id;
            Person.playersDeath[cont] = other.gameObject;
            Destroy(other.gameObject);
            cont++;
        }

        if(cont == Person.modo - 1) {
            // this.Quem();
            ManagerScene manager = new ManagerScene();
            manager.Vitoria();
            // DontDestroyOnLoad();
        }
    }

    // void Quem(){

        // bool flag = true;
        // for(int i = 0; i< Person.modo-1; i++ ){
            // for(int j = 0;j < Person.modo-1;j++)
                // if(Person.playersSelect[i] == Person.playersDeath[j]) flag = false;
                
            // if(flag){
                // Debug.Log("Entrou");
                // Person.vitoria = Person.playersBack[i];
                // Debug.Log(Person.playersBack[i]);
                // break;
            // }
        // }
    // }
}
