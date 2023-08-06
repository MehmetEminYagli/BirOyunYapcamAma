using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public GameObject TekrarlaBtn;
    void Start()
    {
        TekrarlaBtn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TerkarlaBtn()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }


}
