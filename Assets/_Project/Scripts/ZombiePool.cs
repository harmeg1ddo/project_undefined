using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombiePool : MonoBehaviour
{
    public GameObject zombieTypeA;
    public int poolSizeZombieTypeA;
    private List<GameObject> _PoolZombieTypeA;

    // Start is called before the first frame update
    void Start()
    {
        _PoolZombieTypeA = new List<GameObject>();
        for (int i = 0; i <= poolSizeZombieTypeA; i++)
        {
            GameObject temp= Instantiate(zombieTypeA,
                new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z), 
                Quaternion.identity);
            temp.transform.parent = gameObject.transform;
            temp.transform.localPosition = Vector3.zero;
            temp.SetActive(false);
            _PoolZombieTypeA.Add(temp);
        }
    }
    public GameObject GetZombieTypeA()
    {
        for (int i = 0; i <= poolSizeZombieTypeA; i++)
        {
            if (!_PoolZombieTypeA[i].activeSelf)
            {
                _PoolZombieTypeA[i].SetActive(true);
                return _PoolZombieTypeA[i];
            }
        }
        return null;
    }
}
