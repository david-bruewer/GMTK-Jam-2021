using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Vector2 spawnpoint;
    public GameObject particle;

    // Start is called before the first frame update
    void Start()
    {
        spawnpoint = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Die()
    {
        StartCoroutine(Dying());
    }

    public IEnumerator Dying()
    {
        particle.SetActive(false);
        particle.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<BoxCollider2D>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        gameObject.SetActive(false);
    }
}
