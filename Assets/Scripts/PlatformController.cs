using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private Collider2D _collider;
    void Start()
    {
        _collider = GetComponent<Collider2D>();
        _collider.isTrigger = true;
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("içindenGeçti");
            _collider.isTrigger = false;
        }
    }
}
   

