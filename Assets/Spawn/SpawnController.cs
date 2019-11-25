using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
    public GameObject PreMeteoro;
    public GameObject Meteoro;
    public GameObject Raio;
    public GameObject Explosion;
    public bool explode;

    void Start() {
        criaMeteoro();
        InvokeRepeating("criaMeteoro", 60, 7);
    }

    void Update() {
    }
    public void criaMeteoro() {
        Vector3 RandomPosition = new Vector3(Random.Range(-1.0f, 1.0f), 2, Random.Range(-1.0f, 1.0f));
        StartCoroutine(criaMeteoroElement( 
            Vector3.Scale(RandomPosition, (this.GetComponent<Renderer>().bounds.size / 2)) + this.transform.position, 3f));   
    }

    IEnumerator criaMeteoroElement(Vector3 Position, float delay) {
        GameObject Pre = Instantiate(this.PreMeteoro, Position, Quaternion.Euler(0, 0, 0));        
        yield return new WaitForSeconds(delay);
        Destroy(Pre);

        GameObject Met = Instantiate(this.Meteoro, Position, Quaternion.Euler(0f, -125f, 90f));
        GameObject bola = Instantiate(this.Explosion, Position, Quaternion.Euler(0, 0, 0));        
        bola.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        yield return new WaitForSeconds(0.6f);
        StartCoroutine(ExplodeExpand(bola));
        yield return new WaitForSeconds(1.5f);
        Destroy(Met);
    }
    IEnumerator ExplodeExpand(GameObject bola) {
        while(bola.transform.localScale.x < 3f) {
            bola.transform.localScale = new Vector3(1f, 1f, 1f) + bola.transform.localScale;
            yield return new WaitForSeconds(0.05f);
        }        
        Destroy(bola);
        yield break;
    }
    public void criaRaio(Vector3 position) {
        Instantiate(Raio, position, Quaternion.Euler(0, 0, 0));
    }
}
