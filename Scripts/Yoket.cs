using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoket : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D bul)
    {
        Destroy(bul.gameObject);
    }
}
