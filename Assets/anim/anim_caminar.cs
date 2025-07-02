using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim_caminar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animation>().Play("CORRER");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Animation>().Play("CORRER");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Animation>().Play("CORRER");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Animation>().Play("CORRER");
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            GetComponent<Animation>().Play("ATACAR");
        }
    }
}
