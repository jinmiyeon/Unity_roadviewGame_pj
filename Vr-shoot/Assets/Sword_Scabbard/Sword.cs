using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public float attackAmount = 20.0f;
    public AudioClip swordClip;
    AudioSource swordAudio;
    // Start is called before the first frame update
    void Start()
    {
        swordAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Monster") // BulletSpawner
        {
            BulletSpawner bulletmonster = other.GetComponent<BulletSpawner>();

            if (bulletmonster != null)
            {
                bulletmonster.GetDamage(attackAmount);
            }
            swordAudio.PlayOneShot(swordClip);
        }
        else if (other.tag == "Monster2") // Alien Monster
        {
            MonsterCtrl alien = other.GetComponent<MonsterCtrl>();

            if (alien != null)
            {
                alien.GetDamage(attackAmount);
            }
            swordAudio.PlayOneShot(swordClip);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
