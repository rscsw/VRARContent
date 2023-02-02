using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefabs;
    public Transform gunBarrelEnd;
    public ParticleSystem gunParticle;
    public AudioSource gunAudioSource;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefabs, gunBarrelEnd.position, gunBarrelEnd.rotation);
        gunParticle.Play();
        gunAudioSource.Play();
    }
}
