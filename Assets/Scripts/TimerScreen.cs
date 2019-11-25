using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScreen : MonoBehaviour {
    public const float FIRST_DROP = 120.0f;
    public const float SECOND_DROP = 60.0f;

    public Text timerText;
    private float startTime = 210.0f;
    private GameObject earthDrop;
    bool dropped1 = false;
    bool dropped2 = false;
    bool dropped3 = false;

    public Text p3, p4;
    public Image b3, b4;

    void Start()
    {
        Debug.Log(Person.modo);
        if (Person.modo == 2) {
            p3.enabled = false;
            p4.enabled = false;
            b3.enabled = false;
            b4.enabled = false;
        } else if (Person.modo == 3) {
            p4.enabled = false;
            b4.enabled = false;
        }
    }
    
    void Update()
    {
        startTime -= Time.deltaTime;

        if (startTime >= 0.0) {
            if (startTime <= FIRST_DROP + 10 && dropped1 == false) {
                if (startTime >= FIRST_DROP + 5.00) {
                    timerText.color = Color.yellow;
                } else if (startTime >= FIRST_DROP) {
                    timerText.color = Color.red;
                } else {
                    earthDrop = GameObject.Find("FragDisc_externo");
                    earthDrop.GetComponent<MeshCollider>().convex  = true;
                    earthDrop.GetComponent<Rigidbody>().isKinematic = false;
                    earthDrop.GetComponent<Rigidbody>().useGravity = true;
                    dropped1 = true;
                    timerText.color = Color.white;
                }
            }

            if (startTime <= SECOND_DROP + 10 && dropped2 == false) {
                if (startTime >= SECOND_DROP + 5.00) {
                    timerText.color = Color.yellow;
                } else if (startTime >= SECOND_DROP) {
                    timerText.color = Color.red;
                } else {
                    earthDrop = GameObject.Find("FragDisc_meio");
                    earthDrop.GetComponent<MeshCollider>().convex  = true;
                    earthDrop.GetComponent<Rigidbody>().isKinematic = false;
                    earthDrop.GetComponent<Rigidbody>().useGravity = true;
                    dropped2 = true;
                    timerText.color = Color.yellow;
                }
            }

            if(dropped1 && dropped2) {
                if (startTime <= 10) {
                    timerText.color = Color.red;
                }
            }

            int minutes = (int)startTime / 60;
            int seconds = (int)startTime % 60;

            string min, sec;

            if (minutes < 10) {
                min = "0" + minutes.ToString();
            } else {
                min = minutes.ToString();
            }

            if (seconds < 10) {
                sec = "0" + seconds.ToString();
            } else {
                sec = seconds.ToString();
            }

            timerText.text = min + ":" + sec;
        } else {
            timerText.text = "00:00";
            earthDrop = GameObject.Find("FragDisc_interno");
            earthDrop.GetComponent<MeshCollider>().convex  = true;
            earthDrop.GetComponent<Rigidbody>().isKinematic = false;
            earthDrop.GetComponent<Rigidbody>().useGravity = true;

            if (startTime <= -1) {
                ManagerScene manager = new ManagerScene();
                manager.MenuGame();
            }
        }

    }
}
