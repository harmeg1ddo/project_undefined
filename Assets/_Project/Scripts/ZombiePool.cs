using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombiePool : MonoBehaviour
{
    public GameObject ZombieType_A;
    public int PoolSize_ZombieType_A;
    private List<GameObject> _Pool_ZombieType_A;

    // Start is called before the first frame update
    void Start()
    {
        _Pool_ZombieType_A = new List<GameObject>();
        for (int i = 0; i <= PoolSize_ZombieType_A; i++)
        {
            GameObject temp= Instantiate(ZombieType_A,
                new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z), 
                Quaternion.identity);
            temp.transform.parent = gameObject.transform;
            temp.transform.localPosition = new Vector3(0, 0, 0);
            temp.SetActive(false);
            _Pool_ZombieType_A.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject get_ZombieType_A()
    {
        for (int i = 0; i <= PoolSize_ZombieType_A; i++)
        {
            if (!_Pool_ZombieType_A[i].activeSelf)
            {
                _Pool_ZombieType_A[i].SetActive(true);
                return _Pool_ZombieType_A[i];
            }
        }
        return null;
    }
}
