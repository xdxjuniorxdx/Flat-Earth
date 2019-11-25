using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeyMan : MonoBehaviour{

    private Animator animator;
    Rigidbody rigid;
    bool movimento = false;
    public float velocidade = 5;
    public float controlPlayer;
    //bool habilidade = false;

    //float timerBegin;
    //float timerFinish;

    //ANIMACAO
    private float correr = 0;
    private float empurrar = 0;
    private float cair = 0;


    void player1(){
        if (Input.GetKey("w")){
            animator.SetFloat("Correr", 1);
            transform.Translate(0, 0, (velocidade * Time.deltaTime));

            animator.SetFloat("Empurrar", -1);
        }
        if (Input.GetKey("s")){
            animator.SetFloat("Correr", 1);
            transform.Translate(0, 0, (-velocidade * Time.deltaTime));

            animator.SetFloat("Empurrar", -1);
        }

        if (Input.GetKey("a")){
            animator.SetFloat("Correr", 1);
            transform.Rotate(0, (-velocidade * Time.deltaTime) * 40, 0);

            animator.SetFloat("Empurrar", -1);
        }

        if (Input.GetKey("d")){
            animator.SetFloat("Correr", 1);
            transform.Rotate(0, (velocidade * Time.deltaTime) * 40, 0);

            animator.SetFloat("Empurrar", -1);
        }

        //empurrar
        if (Input.GetKey(KeyCode.Space)){
            animator.SetFloat("Empurrar", 1);
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
        }

        //pular
        if (Input.GetKey(KeyCode.LeftAlt)){

        }

    }

    void player2(){
        if (Input.GetKey(KeyCode.UpArrow)){
            animator.SetFloat("Correr", 1);
            transform.Translate(0, 0, (velocidade * Time.deltaTime));

            animator.SetFloat("Empurrar", -1);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            animator.SetFloat("Correr", 1);
            transform.Translate(0, 0, (-velocidade * Time.deltaTime));

            animator.SetFloat("Empurrar", -1);
        }

        if (Input.GetKey(KeyCode.LeftArrow)){
            animator.SetFloat("Correr", 1);
            transform.Rotate(0, (-velocidade * Time.deltaTime) * 40, 0);

            animator.SetFloat("Empurrar", -1);
        }

        if (Input.GetKey(KeyCode.RightArrow)){
            animator.SetFloat("Correr", 1);
            transform.Rotate(0, (velocidade * Time.deltaTime) * 40, 0);

            animator.SetFloat("Empurrar", -1);
        }

        //empurrar
        if (Input.GetKey(KeyCode.RightControl)){
            animator.SetFloat("Empurrar", 1);
            GetComponent<AudioSource>().Play();
            GetComponent<Renderer>().enabled = false;
        }

        //pular
        if (Input.GetKey(KeyCode.RightAlt)){

        }

    }

    void Start(){
        rigid = gameObject.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        
    }

    void Update(){
        movimento = false;
        //timerBegin = Time.time;

        //if (timerBegin >= timerFinish && habilidade == true){
        //    habilidade = false;
        //    velocidade = velocidade / 2;
        //}

        GetComponent<AudioSource>().Pause();

        animator.SetFloat("Correr", -1);
        animator.SetFloat("Empurrar", -1);

        if (controlPlayer == 0) player1();
        else if (controlPlayer == 1) player2();

    }
}
