using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform TargetBall;
    [SerializeField] private float lerpvalue;
    private Vector3 offset;
    private Vector3 newPosition;
    
    void Start()
    {
        offset = transform.position - TargetBall.position;
    }

    private void LateUpdate()
    {
        CameraTakip();
    }
    private void CameraTakip()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0, TargetBall.position.y, 0) + offset, lerpvalue * Time.deltaTime);
        transform.position = newPosition;   
    }
}
