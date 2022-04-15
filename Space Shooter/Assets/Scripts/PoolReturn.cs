using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolReturn : MonoBehaviour
{
    private ObjectPool pool;
    //Start is called once before the update
    private void Start()
    {
        pool = ObjectPool.POOL; //find the game manager
    }//end Start()

    private void OnDisable()
    {
        //if the pool is not empty
        if (pool != null)
        {
            pool.ReturnObject(this.gameObject); //return to pool
        }//end if ( pool != null)
    }//end OnDisable()
}
