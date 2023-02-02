using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMove : MonoBehaviour
{
    public float zombieSpeed;
    public AudioClip[] zombieSound;

    private Vector3 player;
    private Animator ani;
    private AudioSource _audioSource;

    void Start()
    {
        player = new Vector3(0, 0, -5);
        zombieSpeed = 1.5f;
        ani = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

        _audioSource.PlayOneShot(zombieSound[Random.Range(0, 2)]);
    }

    void Update()
    {
        transform.LookAt(player);
        transform.position = Vector3.MoveTowards(transform.position, player, zombieSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            _audioSource.PlayOneShot(zombieSound[2]);
            ani.SetTrigger("Attack");
            zombieSpeed = 0f;
        }
    }
}
