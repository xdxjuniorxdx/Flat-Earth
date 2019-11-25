using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionPush : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        print(other.contacts[0].normal);
        other.gameObject.GetComponent<Rigidbody>().AddForce(other.contacts[0].normal * 15, ForceMode.VelocityChange);
        // other.gameObject.rigid.AddRelativeForce(this.gameObject.contacts.normal * 10);
    }
    
}
