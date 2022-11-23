using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Damager
{
    public float Delay = 3f;
    public float Radius = 5f;
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
        var delayedExplosion = Instantiate(ExplosionEffect, transform.position, transform.rotation);
        var colliders = Physics.OverlapSphere(transform.position, Radius);
        foreach (var nearbyObj in colliders)
        {
            if (nearbyObj.TryGetComponent(out Damageable damageable))
            {
                Damage(damageable);
            }
        }
        // Remove bomb parts
        Destroy(gameObject);
        Destroy(delayedExplosion, 2);
    }
}
