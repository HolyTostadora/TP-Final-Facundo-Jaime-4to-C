using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasadorObjeto : MonoBehaviour
{
    public GameObject[] cubes;
    public int Index = 10;
    

    void Start()
    {
        DeactivateAll();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ActivatePrevious();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ActivateNext();
        }
    }

    public void ActivateNext()
    {
        Index++;
        if (Index >= cubes.Length)
        {
            Index = 0;

        }

        DeactivateAll();
        cubes[Index].SetActive(true);
    }

    public void ActivatePrevious()
    {
        Index--;
        if (Index < 0)
        {
            Index = cubes.Length - 1;
        }
        DeactivateAll();
        cubes[Index].SetActive(true);
    }

    void DeactivateAll()
    {
        for (int i = 0; i < cubes.Length; i++)
        {
            cubes[i].SetActive(false);
        }
    }

    

}
