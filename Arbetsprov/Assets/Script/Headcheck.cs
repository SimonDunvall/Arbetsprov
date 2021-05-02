using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Headcheck : MonoBehaviour
{
    GameObject Enemy;

    void Start()
    {
        Enemy = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Collider2D>().enabled = false;
        Enemy.GetComponent<Collider2D>().enabled = false;
    }

}
