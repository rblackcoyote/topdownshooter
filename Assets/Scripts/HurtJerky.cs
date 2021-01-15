using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtJerky : MonoBehaviour
{

    public int damageToGive;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "JerkyRack")
        {
            other.gameObject.GetComponent<JerkyHealthController>().HurtJerky(damageToGive);
        }
    }
}
