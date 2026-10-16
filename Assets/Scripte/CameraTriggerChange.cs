using System;
using Unity.Cinemachine;
using UnityEngine;

public class CameraTriggerChange : MonoBehaviour
{
    [SerializeField]private CinemachineCamera _origin;
    [SerializeField]private CinemachineCamera _destination;
    
    private void OnTriggerEnter(Collider other)
    {
        _origin.Priority = 1;
        _destination.Priority = 2; 
        Destroy(gameObject);
    }
}
