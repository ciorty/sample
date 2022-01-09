using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class animations_ego : MonoBehaviour
{
    public string once;
    public Animator animator;

    public int melee_activ;

    public GameObject arma;

    void Start ()
    {
        once = "neutru";
        animator = GetComponent<Animator>();
    }



    public void idle()
    {
        if (once == "idle")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("idle_unarmed", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("idle_melee_weapon", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("idle_gun", 0.3f); }
            if (orientare_0.game_mode == "pick") { animator.CrossFadeInFixedTime("idle_unarmed", 0.3f); }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("idle_unarmed", 0.3f); }
            once = "neutru_idle";
        }
    }

    public void run()
    {
        if (once == "run")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("run_unarmed", 0.2f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("run_melee_weapon", 0.2f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("run_gun", 0.2f); }
            if (orientare_0.game_mode == "pick") { animator.CrossFadeInFixedTime("run_unarmed", 0.3f); }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("run_unarmed", 0.3f); }
            once = "neutru_run";
        }
    }

    public void push()
    {
        if (once == "push")
        {

            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("push", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("push", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("push", 0.3f); }
            if (orientare_0.game_mode == "pick") { animator.CrossFadeInFixedTime("push", 0.3f); }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("push", 0.3f); }

            once = "neutru_push";
        }
    }


    public void drag()
    {
        if (once == "drag")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("drag", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("drag", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("drag", 0.3f); }
            if (orientare_0.game_mode == "pick") { animator.CrossFadeInFixedTime("drag", 0.3f); }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("drag", 0.3f); }

            once = "neutru_drag";
        }
    }

    public void left()
    {
        if (once == "left")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("left_unarmed", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("left_melee", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("left_gun", 0.3f); }
            if (orientare_0.game_mode == "pick") { animator.CrossFadeInFixedTime("left_unarmed", 0.3f); }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("left_unarmed", 0.3f); }
            once = "neutru_left";
        }
    }

    public void right()
    {
        if (once == "right")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("right_unarmed", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("right_melee", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("right_gun", 0.3f); }
            if (orientare_0.game_mode == "pick") { animator.CrossFadeInFixedTime("right_unarmed", 0.3f); }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("right_unarmed", 0.3f); }
            once = "neutru_right";
        }
    }

    public void back()
    {
        if (once == "back")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("back_unarmed", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("back_melee_weapon", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("back_gun", 0.3f); }
            if (orientare_0.game_mode == "pick") { animator.CrossFadeInFixedTime("back_unarmed", 0.3f); }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("back_unarmed", 0.3f); }
            once = "neutru_back";
        }
    }

    public void hit()
    {
        if (once == "hit")
        {
             if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("hit_unarmed", 0.2f); }
             if (orientare_0.game_mode == "melee")
            {
                animator.CrossFadeInFixedTime("hit_melee_weapon", 0.2f);


            }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("hit_gun", 0.2f); }
            if (orientare_0.game_mode == "pick")
            {
                //animator.CrossFadeInFixedTime("hit_pick", 0.3f);
            }
            if (orientare_0.game_mode == "climb") { animator.CrossFadeInFixedTime("hit_gun", 0.3f); }
            once = "neutru_hit";
        }
    }

    public void change_weapon()
    {
        if (once == "change_weapon")
        {
            animator.CrossFadeInFixedTime("weapon_change", 0.2f);
            once = "neutru_change_weapon";
        }
    }

    public void jump_from_stand()
    {
        if (once == "jump_from_stand")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("jump_from_stand", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("jump_from_stand", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("jump_from_stand", 0.3f); }
            once = "neutru_jump_from_stand";
        }
    }

    public void jump_from_move()
    {
        if (once == "jump_from_move")
        {
            if (orientare_0.game_mode == "move") { animator.CrossFadeInFixedTime("jump_from_move", 0.3f); }
            if (orientare_0.game_mode == "melee") { animator.CrossFadeInFixedTime("jump_from_move", 0.3f); }
            if (orientare_0.game_mode == "fight") { animator.CrossFadeInFixedTime("jump_from_move", 0.3f); }
            once = "neutru_jump_from_move";
        }
    }

    public void fall_move()
    {
        if (once == "fall_move")
        {
            //   if (orientare_0.once_jump == 1) { animator.CrossFadeInFixedTime("fall_2", 0.3f); }
            //   if (orientare_0.once_jump == 0) { animator.CrossFadeInFixedTime("fall_1", 0.3f); }
            animator.CrossFadeInFixedTime("fall_move", 0.2f);
            once = "neutru_fall_move";
        }
    }

    public void fall_stand()
    {
        if (once == "fall_stand")
        {
            //   if (orientare_0.once_jump == 1) { animator.CrossFadeInFixedTime("fall_2", 0.3f); }
            //   if (orientare_0.once_jump == 0) { animator.CrossFadeInFixedTime("fall_1", 0.3f); }
            animator.CrossFadeInFixedTime("fall_stand", 0.2f);
            once = "neutru_fall_stand";
        }
    }

    public void land()
    {
        if (once == "land")
        {
            animator.CrossFadeInFixedTime("land", 0.1f); 
            once = "neutru_land";
        }
    }

    public void climb_over_low()
    {
        if (once == "climb_over_low")
        {
            animator.CrossFadeInFixedTime("climb_over_low", 0.2f);
            once = "neutru_climb_over_low";
        }
    }

    public void climb_over_high()
    {
        if (once == "climb_over_high")
        {
            animator.CrossFadeInFixedTime("climb_over_high", 0.2f);
            once = "neutru_climb_over_high";
        }
    }

    public void over_to_stabile()
    {
        if (once == "over_to_stabile")
        {
            animator.CrossFadeInFixedTime("over_to_stabile", 0.2f);
            once = "neutru_over_to_stabile";
        }
    }

    public void rope_climbing()
    {
        if (once == "rope_climbing")
        {
            animator.CrossFadeInFixedTime("rope_climbing", 0.4f);
            once = "neutru_rope_climbing";
        }
    }

    public void ladder_climbing()
    {
        if (once == "ladder_climbing")
        {
            animator.CrossFadeInFixedTime("ladder_climbing", 0.4f);
            once = "neutru_ladder_climbing";
        }
    }

    public void die()
    {
        if (once == "die")
        {
            animator.CrossFadeInFixedTime("die", 0.2f);
            once = "neutru_die";
        }
    }







    void Update()
    {
        die();
        idle();
        run();
        left();
        right();
        back();
        hit();
        change_weapon();
        jump_from_stand();
        jump_from_move();
        fall_stand();
        fall_move();
        land();
        climb_over_low();
        climb_over_high();
        over_to_stabile();
        rope_climbing();
        ladder_climbing();
        push();
        drag();

        
        if (once == "neutru_hit")
        {
            if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime > 0.3f)
            {
                melee_activ = 1;
                arma.tag = "sword";
            }
        }
        if (once != "neutru_hit")
        {
            melee_activ = 0;
            arma.tag = "non_sword";
        }
        

        //Debug.Log(melee_activ);
        
    }
}