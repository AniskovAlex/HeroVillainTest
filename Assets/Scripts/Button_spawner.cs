using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_spawner : MonoBehaviour
{
    [SerializeField] GameObject button;

    private void Start()
    {
        button.SetActive(false);
    }

    private void OnMouseDown()
    {
        button.SetActive(true);
    }
}
