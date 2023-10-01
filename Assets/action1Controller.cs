using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action1Controller : MonoBehaviour
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
        if (Input.GetKey(KeyCode.A))
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            //gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }
}
