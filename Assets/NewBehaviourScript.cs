using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddTorque(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.AddTorque(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddTorque(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddTorque(0, 0, -1);
        }
        if(this.transform.position.y < -10)
        {
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.angularVelocity = Vector3.zero;
            transform.position = new Vector3(0, 2, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        /*
        var item = collision.gameObject.GetComponent<item>();
        if(item != null)

          if(collision.gameObject.name == "Item")
          {
              Destroy(collision.gameObject);
          }
       */
         
        Debug.Log("衝突" + collision.gameObject.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        var item = other.gameObject.GetComponent<item>();
        if (item != null)
        {
            // Debug.Log("トリガー" + other.gameObject.name);
            Destroy(other.gameObject);
        }
    }

}
