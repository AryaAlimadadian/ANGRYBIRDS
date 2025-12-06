using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{
    [SerializeField] private GameObject _cloud;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.GetComponent<Gg>()!=null)
        {
            Instantiate(_cloud, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }

        
        if (collision.collider.GetComponent<Kill>()!=null)
        {
            return;
        }

        if (collision.contacts[0].normal.y < -0.5)
        {
            Instantiate(_cloud, transform.position, Quaternion.identity);
            Destroy(gameObject);
            return;
        }
    }
}
