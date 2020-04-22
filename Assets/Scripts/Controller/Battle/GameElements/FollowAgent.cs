using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowAgent : MonoBehaviour
{
    public Transform _target;

    private NavMeshAgent _nv;

    public float _distanceToQuarz;
    
    // Start is called before the first frame update
    void Start()
    {
        _nv = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    
    
        void Update()
        {
            _nv.stoppingDistance = _distanceToQuarz;
            if (Vector3.Distance(transform.position, _target.position)>_distanceToQuarz)
            {
                
                _nv.SetDestination(_target.position );
                 _nv.speed = 4.5f;
            }
            else
            {
                if (Vector3.Distance(transform.position, _target.position)<=_distanceToQuarz)
                {
                    _nv.speed = 0;
                }
            }
        }
}
