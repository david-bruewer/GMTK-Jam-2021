using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public GameObject present; 
    public GameObject past;

    public Animator anim;

    public AudioSource pastMusic; 
    public AudioSource presentMusic;

    public AudioSource timeEffect;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchTimelines()
    {
        StartCoroutine(waitAnimation());
    }

    public IEnumerator waitAnimation()
    {
        if (present.activeSelf)
        {
        
            timeEffect.Play();
            anim.SetTrigger("Past");
            presentMusic.mute = true; 
            pastMusic.mute = false;
           // anim.SetBool("isFuture", false);

            yield return new WaitForSeconds(0.25f);
            present.SetActive(false);
            past.SetActive(true);
            pastMusic.mute = false; 
        }
        else
        {
            timeEffect.Play();
            anim.SetTrigger("Future");
            pastMusic.mute = true; 
            presentMusic.mute = false;
           // anim.SetBool("isFuture", true);
            yield return new WaitForSeconds(0.25f);
            past.SetActive(false);
            present.SetActive(true);
 
        }
    }


}
