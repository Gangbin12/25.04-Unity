using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform parentPosition;

    void Start()
    {
        Instantiate(prefab, parentPosition);
    }
}
