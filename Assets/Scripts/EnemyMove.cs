using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float movespeed;
    [SerializeField] private bool isRight;
    [SerializeField] private GameManager _gameManager;
    void Start()
    {
        randomYon();
        _gameManager = FindAnyObjectByType<GameManager>();
    }


    private void FixedUpdate()
    {
        EnemeyMove();
    }

    void randomYon()
    {
        if (Random.Range(0, 2) == 0)
        {
            isRight = true;
        }
        else
        {
            isRight = false;
        }

    }


    void EnemeyMove()
    {
       

        if (!isRight)
        {
            transform.position -= Vector3.right * movespeed * Time.fixedDeltaTime;

        }
        else
        {
            transform.position += Vector3.right * movespeed * Time.fixedDeltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("SagDuvar"))
        {
            isRight = false;
        }
        else if (collision.gameObject.CompareTag("SolDuvar"))
        {
            isRight = true;
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
            
            Debug.Log("Kaybettin");
            _gameManager.TekrarlaBtn.SetActive(true);
        }
    }
}
