using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCooldowns : MonoBehaviour
{
    public Animator animator;
    public float super_push_cooldown;
    public float super_push_cooldown_base_value;
    public bool super_push_in_cooldown;

    public void start_push() {
        set_push();

    }

    public void set_push() {
        animator.SetBool("Empurrar", true);
    }

    public void tick_super_push_cooldown()
    {
        super_push_cooldown -= Time.deltaTime;
        if (super_push_cooldown <= 0)
        {
            super_push_in_cooldown = false;
        }
    }

    public void start_super_push()
    {
        if (!super_push_in_cooldown) {
            set_super_push();
            super_push_cooldown = super_push_cooldown_base_value;
            super_push_in_cooldown = true;
        }
    }

    public void set_super_push()
    {
        if (super_push_in_cooldown == false) {
            animator.SetBool("Ultar", true);
        }
    }

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (super_push_in_cooldown) {
            tick_super_push_cooldown();
        }
    }

}
