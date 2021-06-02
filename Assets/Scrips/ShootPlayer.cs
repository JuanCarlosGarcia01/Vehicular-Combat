using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShootPlayer : MonoBehaviour
{
    [Header("Disparo")]
    public GameObject BulletPrefab;
    public Transform BulletSpawn;

    public float TimeBetweenShoots = 0.3333f;
    private float moveTimeStamp = 0f;

    private void FixedUpdate()
    {
        if ((Time.time >= moveTimeStamp) && (Input.GetKey(KeyCode.Mouse0)))
        {
            Fire();
            moveTimeStamp = Time.time + TimeBetweenShoots;
        }
    }

    void Fire()
    {
        var bullet = (GameObject)Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 50;

        Destroy(bullet, 2.0f);

    }
}
