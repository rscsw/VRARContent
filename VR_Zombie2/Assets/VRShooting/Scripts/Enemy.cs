using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public AudioClip spawnClip;
    public AudioClip hitClip;

    private Collider enemyCollider;
    private AudioSource audioSource;

    int point = 1;
    Score score;
    GameObject gameObj;

    void Start()
    {
        enemyCollider = GetComponent<CapsuleCollider>();
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(spawnClip);

        gameObj = GameObject.FindWithTag("Score");
        score = gameObj.GetComponent<Score>();
    }

    void OnHitBullet()
    {
        audioSource.PlayOneShot(hitClip);
        GoDown();
    }

    void GoDown()
    {
        score.AddScore(point);
        enemyCollider.enabled = false;
        Destroy(gameObject, 1f);
    }
}
