using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public GameObject clear;

    private void OnTriggerEnter(Collider other)
    {
        clear.SetActive(true);
    }
}
