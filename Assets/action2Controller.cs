using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action2Controller : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Destroy(this.gameObject);
        }
    }
}
