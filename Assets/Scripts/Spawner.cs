using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] public GameObject cactusPrefab;
    [SerializeField] Toggle IDLE;
    [SerializeField] Toggle Walk;
    [SerializeField] Toggle Attack;
    [SerializeField] Toggle BossAttack;
    [SerializeField] Toggle Death;

    Animator animator;

    public void Spawn(bool zoneTL,bool zoneBL, bool zoneTR, bool zoneBR, int quantity, int rotation)
    {        
        if (zoneTL)
        {
            for(int i = 0; i < quantity; i++)
            {
                Vector3 positionTL = new Vector3(Random.Range(-0.1f,-15f), 0, Random.Range(0.1f, 20f));
                GameObject obj = Instantiate(cactusPrefab, positionTL, transform.rotation * Quaternion.Euler(0f,rotation,0f));

                animator = obj.GetComponent<Animator>();
                Animate();
            }            
        }
        if (zoneBL)
        {
            for (int i = 0; i < quantity; i++)
            {
                Vector3 positionBL = new Vector3(Random.Range(-0.1f, -15f), 0, Random.Range(-0.1f, -20f));
                GameObject obj = Instantiate(cactusPrefab, positionBL, transform.rotation * Quaternion.Euler(0f, rotation, 0f));

                animator = obj.GetComponent<Animator>();
                Animate();
            }
        }
        if (zoneTR)
        {
            for (int i = 0; i < quantity; i++)
            {
                Vector3 positionTR = new Vector3(Random.Range(0.1f, 15f), 0, Random.Range(0.1f, 20f));
                GameObject obj = Instantiate(cactusPrefab, positionTR, transform.rotation * Quaternion.Euler(0f, rotation, 0f));

                animator = obj.GetComponent<Animator>();
                Animate();
            }
        }
        if (zoneBR)
        {
            for (int i = 0; i < quantity; i++)
            {
                Vector3 positionBR = new Vector3(Random.Range(0.1f, 15f), 0, Random.Range(-0.1f, -20f));
                GameObject obj = Instantiate(cactusPrefab, positionBR, transform.rotation * Quaternion.Euler(0f, rotation, 0f));

                animator = obj.GetComponent<Animator>();
                Animate();
               
            }
        }
    }  
    void Animate()
    {
        var randomize = new List<int>();

        if (IDLE.isOn == true)
        {
            randomize.Add(0);            
        }
        if (Walk.isOn == true)
        {
            randomize.Add(1);
        }
        if (Attack.isOn == true)
        {
            randomize.Add(2);
        }
        if (BossAttack.isOn == true)
        {
            randomize.Add(3);
        }
        if (Death.isOn == true)
        {
            randomize.Add(4);
        }

        if (randomize.Count == 0) return;
        else if (randomize.Count == 1)
        {
            animator.SetInteger("AnimIndex", randomize[0]);
        }
        else
        {            
            animator.SetInteger("AnimIndex", randomize[Random.Range(0, randomize.Count)]);            
        }
    }
    
}
