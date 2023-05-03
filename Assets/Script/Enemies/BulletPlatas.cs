using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlatas : MonoBehaviour
{
    
    public float speed = 2;

    public float lifeTime = 2;

    public bool right;


    private void Start()
    {

    }

    private void Update()
    {
        if(right)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else{
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
