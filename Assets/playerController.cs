using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float power = 10;
    public Rigidbody rigidbody;

    public GameObject[] player;
    private int playerNum = 0;

   
    // Start is called before the first frame update
    void Start()
    {
        //player[0].SetActive(true);
        //player[1].SetActive(false);
    }

    //[SerializeField] Material mat = default;
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 1, 0) * power);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, -1, 0) * power);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }

        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    playerNum = (playerNum + 1) % player.Length;

        //    for (int i = 0; i < player.Length; i++)
        //    {
        //        //if (i == playerNum)
        //        //{
        //        //    player[i].SetActive(true);
        //        //}
        //        //else
        //        //{
        //        //    player[i].SetActive(false);
        //        //}
        //    }
        //}


    }
}
