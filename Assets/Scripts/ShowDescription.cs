using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDescription : MonoBehaviour
{
    [SerializeField] GameObject description;
    bool active;

    void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void OnMouseDown()
    {
        description.SetActive(active = !active);
    }
}
