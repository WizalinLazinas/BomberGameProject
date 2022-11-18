using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float Delay = 3f;
    public GameObject ExplosionEffect;
    float Countdown;
    bool HasExploded;
    // Start is called before the first frame update
    void Start()
    {
        Countdown = Delay;
    }

    // Update is called once per frame
    void Update()
    {
        Countdown -= Time.deltaTime;
        if (Countdown <= 0 && !HasExploded)
        {
            HasExploded = true;
            Explode();
        }
    }
    void Explode()
    {
        //Allah akabar!
        Debug.Log("BOOM!");
        var delayedExplosion = Instantiate(ExplosionEffect, transform.position, transform.rotation);
        //Physics.OverlapSphere()
        //Show explode effect

        //Get nearby objects (destroyeble, entities...)
            // Add force to objects
            // Do damage!
            // Remove entities if needed
        // Remove bomb parts
        Destroy(gameObject);
        Destroy(delayedExplosion, 2);
    }
}
