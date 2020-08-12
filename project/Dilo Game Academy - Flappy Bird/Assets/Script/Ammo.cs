using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Ammo : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Pipe")
        {
            //Memusnahkan object ketika bersentuhan
            //Debug.Log(collision.gameObject);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
