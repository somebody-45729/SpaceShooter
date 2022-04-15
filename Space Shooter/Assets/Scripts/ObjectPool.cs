using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    /* VARIABLES */
    static public ObjectPool POOL;
    #region Pool Singleton
    private Queue<GameObject> projectiles = new Queue<GameObject>(); //the queue for the projectiles
    //Check to make sure only one gm of the GameManager is in the scene

    [Header("Pool Settings")]
    public GameObject projectilePrefab; //projectile prefab
    public int poolStartSize = 5; //starting size of pool
    void CheckPOOLIsInScene()
    {
        //Check if instnace is null

        if (POOL == null)
        {
            POOL = this; //set SHIP to this game object
        }
        else //else if SHIP is not null send an error
        {
            Debug.LogError("POOL.Awake() - Attempeeted to assign second ObjectPool.POOL");
        }
    }//end CheckSHIPIsInScene()

    //Awake is called when the game loads (before starting). Awake only once during the lifetime of the script instance.
    
     void Awake()
     {
        CheckPOOLIsInScene();
    }//end Awake()
     // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < poolStartSize; i++)
        {
            GameObject projectileGO = Instantiate(projectilePrefab); //create prefab instance
            projectiles.Enqueue(projectileGO); //add to queue
            projectileGO.SetActive(false);//hide projectile
        }//end for(int i = 0; i < poolStartSize; i++)
    }//end Start()
}
