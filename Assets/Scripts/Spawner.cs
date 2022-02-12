using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject cactusPrefab;
    [SerializeField] Dropdown dropdown;
    
    public void Spawn(bool zoneTL,bool zoneBL, bool zoneTR, bool zoneBR, int quantity, int rotation)
    {
        cactusPrefab.GetComponent<Animator>().SetTrigger("IDLE");

        if (zoneTL)
        {
            for(int i = 0; i < quantity; i++)
            {
                Vector3 positionTL = new Vector3(Random.Range(-0.1f,-15f), 0, Random.Range(0.1f, 20f));
                Instantiate(cactusPrefab, positionTL, transform.rotation * Quaternion.Euler(0f,rotation,0f));
            }            
        }
        if (zoneBL)
        {
            for (int i = 0; i < quantity; i++)
            {
                Vector3 positionBL = new Vector3(Random.Range(-0.1f, -15f), 0, Random.Range(-0.1f, -20f));
                Instantiate(cactusPrefab, positionBL, transform.rotation * Quaternion.Euler(0f, rotation, 0f));
            }
        }
        if (zoneTR)
        {
            for (int i = 0; i < quantity; i++)
            {
                Vector3 positionTR = new Vector3(Random.Range(0.1f, 15f), 0, Random.Range(0.1f, 20f));
                Instantiate(cactusPrefab, positionTR, transform.rotation * Quaternion.Euler(0f, rotation, 0f));
            }
        }
        if (zoneBR)
        {
            for (int i = 0; i < quantity; i++)
            {
                Vector3 positionBR = new Vector3(Random.Range(0.1f, 15f), 0, Random.Range(-0.1f, -20f));
                Instantiate(cactusPrefab, positionBR, transform.rotation * Quaternion.Euler(0f, rotation, 0f));
            }
        }
    }  
    void Animate()
    {
        if(dropdown.value == 0)
        {
            cactusPrefab.GetComponent<Animator>().SetTrigger("IDLE");
        }
        if (dropdown.value == 1)
        {
            cactusPrefab.GetComponent<Animator>().SetTrigger("Move");
        }
        if (dropdown.value == 2)
        {
            cactusPrefab.GetComponent<Animator>().SetTrigger("Attack");
        }
        if (dropdown.value == 3)
        {
            cactusPrefab.GetComponent<Animator>().SetTrigger("Death");
        }
    }
}
