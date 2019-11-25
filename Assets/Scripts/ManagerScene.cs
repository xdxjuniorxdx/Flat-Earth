using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScene : MonoBehaviour
{
    void start(){
        
    }

    public void MenuGame(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }

    
    public void Creditos(){
         UnityEngine.SceneManagement.SceneManager.LoadScene("Creditos");
    }

    public void Revelacao(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Intro");
    }

    public void Battle(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Battle");
    }

    public void Vitoria(){
        UnityEngine.SceneManagement.SceneManager.LoadScene("Vitoria");
    }

    public void Sair(){
        Application.Quit();
    }

    public void Players2(){
        Person.modo = 2;
    }

    public void Players3(){
        Person.modo = 3;
    }

    public void Players4(){
        Person.modo = 4;
    }
}
