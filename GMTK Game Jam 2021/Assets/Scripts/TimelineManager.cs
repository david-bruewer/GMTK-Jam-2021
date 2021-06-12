using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineManager : MonoBehaviour
{
    public GameObject present; 
    public GameObject past;

    public Animator anim;
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
            anim.SetBool("isFuture", false);
            yield return new WaitForSeconds(0.25f);
            present.SetActive(false);
            past.SetActive(true);
        }
        else
        {
            anim.SetBool("isFuture", true);
            yield return new WaitForSeconds(0.25f);
            past.SetActive(false);
            present.SetActive(true);
        }
    }


}
