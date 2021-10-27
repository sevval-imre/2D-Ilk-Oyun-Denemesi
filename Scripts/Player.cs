using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float hizlandir=20;
    public float arttir = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal")*Time.deltaTime*hizlandir;
        transform.Translate(x,0,0);
    }
    void OnCollisionEnter2D(Collision2D bul)
    {
        if (bul.gameObject.tag == "top_b")
        {
           /* Debug.Log("Top de�di");
            print("Top de�di");*/
            Destroy(bul.gameObject);
            arttir++;
            
        }
        if (bul.gameObject.tag == "top_y")
        {
            Destroy(bul.gameObject);
            arttir+=10;
        }
        if (bul.gameObject.tag == "top_r")
        {
            Destroy(bul.gameObject);
            arttir-=10;
        }
        //GameObject.Find("Canvas/Text").GetComponent<Text>().text = arttir.ToString();
        GameObject.FindWithTag("skor").GetComponent<Text>().text = arttir.ToString();
    }
}
