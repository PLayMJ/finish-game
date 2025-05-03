using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;


    private void Update()
    {
        AllFruitsCollected();
    }



    public void AllFruitsCollected ()
    {
        if (transform.childCount==0)
        {
            levelCleared.gameObject.SetActive(true);

            Invoke("ChangeScene", 1);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
