using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    }

    private void FixedUpdate()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
        //    Destroy(gameObject);
        //}
    }

    private void OnMouseDown()
    {
        GameManager.Instance.GetScore();
        Destroy(gameObject);
    }


}
