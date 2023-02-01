using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPaintingActive : MonoBehaviour
{
    [SerializeField] GameObject painting;
    
    void Start()
    {
        painting.SetActive(true);
    }

    void Update()
    {
        
    }
}
