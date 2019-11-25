using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnHit : MonoBehaviour {
    // Start is called before the first frame update
    public float cooldown = 1.5f;
    void Start() {        
    }
    private void OnTriggerEnter(Collider other) {
        Invoke("DestroiObjeto", cooldown);
    }
    void DestroiObjeto() {
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
