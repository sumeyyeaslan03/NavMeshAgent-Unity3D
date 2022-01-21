using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class moveCapsules : MonoBehaviour
{
    public NavMeshAgent[] agent;
    public GameObject target;

    void OnMouseDown()
    {
        for(int i = 0; i< 8; i++)
        {
            agent[i].destination = target.transform.position;
        }
        
        
    }
}
