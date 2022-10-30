using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float offset;
    public GameObject ammo;
    public Transform ShotDir;
    private float timeShot;
    public float startime; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation=Quaternion.Euler(0f,0f,rotateZ + offset);

        if (timeShot<=0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(ammo, ShotDir.position, transform.rotation);
                timeShot = startime;
            }

        }
        else
        {
            timeShot-=Time.deltaTime;
        }
    }
}
