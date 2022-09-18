using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(other.gameObject);

        }
        if(other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
    }
}
