using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private Transform spawnPoint;
    [SerializeField]
    private WeaponData weaponData;

    private float cooldown;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && cooldown <= 0)
        {
            Shoot();
        }

        if (cooldown > 0)
            cooldown -= Time.deltaTime;

        Debug.Log(cooldown);
    }

    void Shoot()
    {
        var tempBullet = Instantiate<GameObject>(weaponData.bulletModel);
        tempBullet.transform.position = spawnPoint.position;
        tempBullet.transform.rotation = spawnPoint.rotation;
        tempBullet.GetComponent<Rigidbody2D>().AddForce(tempBullet.transform.up * weaponData.bulletSpeed);
        Destroy(tempBullet, 3f);

        //Reset cooldown
        cooldown = weaponData.fireCooldown;
    }
}
