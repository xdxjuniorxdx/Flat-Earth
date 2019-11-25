using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBattle : MonoBehaviour
{
    public Text p3, p4;
    public Image b3, b4;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(Person.modo);
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
}
