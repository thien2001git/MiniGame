using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, 1f));
    }
}
