using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void StartGame()
    {

        SceneManager.LoadScene("Level1"); //need to update to level 1 when created

    }
}
