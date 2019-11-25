using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SelectMenu : MonoBehaviour
{

    //Quantas pessoas selecionaram gatilho para iniciar a batalha
    int selected;

    public Text texto;

    //objeto referencia 
    GameObject playerInit;

    //Lista de Personagens seleionaveis
    public GameObject[] playersEnable;

    //botoesutilizados no UI
    public Button next, previous, select;

    //Contador para navegação e referencia no menu de seleção
    int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        selected = 1;
        texto.text = "Player 1";
    }

    // Update is called once per frame
    void Update()
    {
        //Sentando o primeiro personagem possivel
        //devemos pre organizar os playersEnable
        if(!playerInit){
            playerInit = GameObject.Find("Spawner");
            playerInit = Instantiate(playersEnable[i], playerInit.transform.position, playerInit.transform.rotation);
            playerInit.GetComponent<Rigidbody>().isKinematic = false;
            playerInit.GetComponent<Rigidbody>().useGravity = false;
            playerInit.transform.localScale += new Vector3(200,200,200);
        }
    }

    public void Next(){
        i++;
        if(i >= playersEnable.Length )i = 0;
        Destroy(playerInit);
    }

    public void Previous(){
        i--;
        if(i < 0 ) i = playersEnable.Length -1;
        Destroy(playerInit);

    }


    //Add o prefab seleacionado pelos players
    public void Select(){        
        Person.playersSelect[selected-1] = playersEnable[i];
        selected++;
        string p = "Player " + selected.ToString();
        
        texto.text = p;
        if(selected - 1 >= Person.modo) Simular();
    }

    //Função encaminhar pra cena jogo
    void Simular(){
        SceneManager.LoadScene("Battle");
        //DontDestroyOnLoad(playerInit);
    }
}
