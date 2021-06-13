using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
  public void play(GameObject levelMenu)
  {
      levelMenu.SetActive(true);

  }

  public void controls (GameObject controlMenu)
  {
      controlMenu.SetActive(true);
  }

  public void exit()
  {
      Application.Quit(); 
  }

  public void back(GameObject buttonParent)
  {
      buttonParent.SetActive(false);
  }

  public void loadLevel(int i)
  {
      SceneManager.LoadScene(i);
  }

  public void restart()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
  }
}
