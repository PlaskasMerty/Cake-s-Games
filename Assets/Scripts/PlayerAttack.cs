//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerAttack : MonoBehaviour
//{

//    public Transform AttackPoint;
//    public LayerMask DamagebleLayerMask;
//    public float Damage;
//    public float AttackRange;
//    public float TimeBtwAttack;

//    private float _timer;

//    private void Update()
//    {
//        Attack();
//    }

//    private void OnDrawGizmosSelected()
//    {
//        Gizmos.color = Color.red;
//        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange)
//    }

//    private void Attack()
//    {
//        if (_timer <= 0)
//        {
//            if ()
//        }
//        else
//        {
//            _timer -= Time.deltaTime;
//        }
//    }

//    private void OnTriggerEnter2D(Collider2D collider)
//    {
//        Player unit = collider.GetComponent<Player>();

//        if (unit && unit.gameObject == Player.Pl)
//        {
//            Player.Lives() -= 1;
//        }
//    }
//}

