using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBack : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Transform _initialposition;


    //[SerializeField]private GameObject _magoPrefab; 
    //[SerializeField]private GameObject _hackerPrefab;
    //[SerializeField]private GameObject _biowarePrefab;

    // [SerializeField] private Transform _initialPosition;

    private void OnTriggerExit(Collider other)
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))

        {
            Destroy(_playerPrefab);
            Instantiate(_playerPrefab, _initialposition);
            //_playerPrefab.transform.position = _initialposition.transform.position;
        }
    }
}
