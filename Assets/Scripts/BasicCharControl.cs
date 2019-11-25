using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BasicCharControl : MonoBehaviour, InputTarget
{
    private Animator animator;
    Rigidbody rigid;

    public int control_player;

    public float translation_force;
    public float rotation_force;

    public int player_id;


    public void moveForward() {
        // if (!(animator.GetBool("Empurrar") || animator.GetBool("Ultar"))) {
        animator.SetBool("Correr", true);
        transform.Translate(Vector3.forward * Time.deltaTime * translation_force);
        // }
    }

    public void turnLeft() {
        transform.Rotate(0f, -rotation_force * Time.deltaTime, 0f);
    }

    public void turnRight() {
        transform.Rotate(0f, rotation_force * Time.deltaTime, 0f);
    }

    public void stop() {
        if (animator.GetBool("Correr") == true) {
            animator.SetBool("Correr", false);
        }
    }

    public void push()
    {
        gameObject.SendMessage("start_push");
    }

    public void superPush()
    {
        gameObject.SendMessage("start_super_push");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player") && (other.gameObject.GetComponent<Animator>().GetBool("Empurrar") == true))
        {
            rigid.AddForce(other.gameObject.GetComponent<Transform>().forward * 20);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (other.gameObject.GetComponent<Animator>().GetBool("Empurrar") == true)
                rigid.AddForce(other.gameObject.GetComponent<Transform>().forward * 50);

            if (other.gameObject.GetComponent<Animator>().GetBool("Ultar") == true)
                rigid.AddForce(other.gameObject.GetComponent<Transform>().forward * 100);

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
