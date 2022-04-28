using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderEvents : MonoBehaviour
{
    private Transform target;
    public float range = 15f;
    public float turnSpeed = 10f;
    public float fireRate = 1f;
    private float fireCountdown = 0f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    

    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;

        foreach(GameObject enemy in enemies)
        {
            float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
            if(distanceToEnemy < shortestDistance)
            {
                shortestDistance = distanceToEnemy;
                nearestEnemy = enemy;

            }
        }

        if(nearestEnemy !=null && shortestDistance <= range)
        {
            target = nearestEnemy.transform;
        }
        else
        {
            target = null;
        }

    }
    
    void Update()
    {
        if (target == null)
            return;

        // HEDEFE K?L?TLENME (TARGET LOCK ON)
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(transform.rotation, lookRotation,Time.deltaTime * turnSpeed).eulerAngles;
        transform.rotation = Quaternion.Euler(0f,rotation.y, 0f);

        if(fireCountdown<= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;

        }

        fireCountdown -= Time.deltaTime;

    }
    void Shoot()
    {
        // KUR?UNDAK? METHODLARA ER??EB?LMEK ?Ç?N KULLANILAN TANIMLAMA
        GameObject bulletGO = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();

        //KUR?UNUN YÖNÜNÜ BEL?RTMEK ?Ç?N BU SCR?PT'DE BULUNAN TARGET'DAN YARARLANDIK
        if (bullet != null)
            bullet.Seek(target);


    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
