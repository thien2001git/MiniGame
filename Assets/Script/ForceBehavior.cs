using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceBehavior : MonoBehaviour
{
    [SerializeField] private float thrust = 10000f;
    [SerializeField] private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string name = collision.gameObject.name;
        if (name.Contains("8"))
        {
            Vector3 up = transform.up * thrust;
            rb.AddForce(up, ForceMode2D.Impulse);
        }
    }
}
