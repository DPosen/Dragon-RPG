using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Characters
{
    [RequireComponent(typeof(WeaponSystem))]
    public class EnemyAI : MonoBehaviour
    {
        [SerializeField] float chaseRadius = 6f;

        bool isAttacking = false; // todo more rich state
        PlayerMovement player = null;
        float currentWeaponRange;

        private void Start()
        {
            player = FindObjectOfType<PlayerMovement>();
        }

        private void Update()
        {
            float distanceToPlayer = Vector3.Distance(player.transform.position, this.transform.position);
            WeaponSystem weaponSystem = GetComponent<WeaponSystem>();
            currentWeaponRange = weaponSystem.GetCurrentWeapon().GetMaxAttackRange();
        }

        private void OnDrawGizmos()
        {
            // Draw attack sphere
            Gizmos.color = new Color(255f, 0, 0, .5f);
            Gizmos.DrawWireSphere(transform.position, currentWeaponRange);

            // Draw move sphere
            Gizmos.color = new Color(0, 0, 255f, .5f);
            Gizmos.DrawWireSphere(transform.position, chaseRadius);
        }
    }
}