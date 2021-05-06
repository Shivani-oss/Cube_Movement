using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PowerUp : MonoBehaviour {

    public float multiplier = 1.4f;
    public float duration = 1f;

    public GameObject pickupEffect;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //StartCoroutine(Pickup(other));
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        // Spawn a cool effect
        Instantiate(pickupEffect, transform.position, transform.rotation);

        //Apply effect to the player
        //PlayerStats stats = player.GetComponent<PlayerStats>();
        //stats.health *= multiplier;
        
        //player.transform.localscale *= multiplier;

        //GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<Collider>().enabled = false; 

        // Wait x amounts of seconds
        //yield return new WaitForSeconds(duration);

        // Reverse the effect on our player
        //stats.health /= multiplier;

        // Remove power up object
        Destroy(gameObject);
    }

    
}
