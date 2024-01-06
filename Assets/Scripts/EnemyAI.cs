using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float speed;
    [SerializeField] private float chaseRange;

    private Vector3 direction;

    // Update is called once per frame
    private void Update()
    {
        if (Vector3.Distance(transform.position, target.position) <= chaseRange)
        {
            direction = (target.position - transform.position);
        }
        else {
            direction = Vector3.zero;
        }

        transform.position += direction.normalized * speed * Time.deltaTime;

    }
}
