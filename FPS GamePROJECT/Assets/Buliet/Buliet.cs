using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buliet : MonoBehaviour
{
    [SerializeField] public float BulietSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        Fire(transform.forward);
    }

    private void Fire(Vector3 movedir)
    {
        transform.position += movedir.normalized * BulietSpeed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("enemy"))
        {
            Debug.Log(other.name);
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}