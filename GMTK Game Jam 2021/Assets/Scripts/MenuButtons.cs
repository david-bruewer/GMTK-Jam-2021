using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

  public AudioSource click; 
    // Start is called before the first frame update
  public void play(GameObject levelMenu)
  {
      click.Play(); 
      levelMenu.SetActive(true);
     

  }

  public void controls (GameObject controlMenu)
  {
      click.Play(); 
      controlMenu.SetActive(true);
  }

  public void exit()
  {
      click.Play(); 
      Application.Quit(); 
  }

  public void back(GameObject buttonParent)
  {
      click.Play(); 
      buttonParent.SetActive(false);
  }

  public void loadLevel(int i)
  {
      click.Play(); 
      SceneManager.LoadScene(i);
  }

  public void restart()
  {
      click.Play(); 
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
