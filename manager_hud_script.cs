using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class manager_hud_script : MonoBehaviour
{
    //public parametrii_ego variabile;


    public Text text_health_current;

    public Text text_score_current;
    public Text text_score_max;

    public int weapon_nr;
    public Text text_ammo_max;
    public Text text_ammo_current;

    private GameObject weapon_image_0;
    private GameObject weapon_image_1;
    private GameObject weapon_image_2;
    //public List<GameObject> weapons_image;

    private RectTransform checkpoint_remark;
    private static float check_indications;
    public static int check_call;
    public static int check_lov;

    private RectTransform inside_continue;

    private RectTransform inside_menu;
    private static float inside_indications;
    private static float inside_continue_y;
    public static int inside_y;
    public static int inside_call;
    public static int inside_lov;

    public RectTransform crane_left;
    public RectTransform crane_right;
    public RectTransform countdown;
    public RectTransform myflash3d;


    private RectTransform start_menu;
    private RectTransform respawn;
    private static float start_indications;
    private static float respawn_indications;
    private static float start_continue_y;
    public static int start_y;
    public static int start_call;
    public static int respawn_call;
    public static int start_lov;

    public GameObject aim;

    //public static RectTransform test_stand_mouse;
    public static RectTransform test_mouse;
    public Camera player;
    Vector2 point;

    public static float Angle;
    public static float Angle3;
    public int ks;
    public static float center_dist;

    int roteste;

    //public static float fata; 

    public static GameObject move_circles;
    public static int by_screen;
    public Image munitie;
    public Image sanatate;
    public RectTransform colectat;
    public RectTransform icon_sanatate;
    public RectTransform compas_all;

    float init_compas;

    float amobar;
    float amomax;

    float lfobar;
    float lfomax;

    Color css;

    public Vector3 dirLookEgo;
    public Vector3 dirMers;
    float unghi_mers;
    float cr_ini;
    float cl_ini;
    float countdown_ini;
    public static GameObject liftul;
    float latime_ecran;

    void Start()
    {
        start_call = 0;
        respawn_call = 1;
        //player = Camera.Find("Camera");
        test_mouse = GameObject.Find("mouse_view").GetComponent<RectTransform>();
        test_mouse.transform.localPosition = new Vector2(0, -200.0f);
        //test_stand_mouse = GameObject.Find("mouse_stand").GetComponent<RectTransform>();

        //checkpoint_remark = GameObject.Find("checkpoint_attention").GetComponent<RectTransform>();
       // check_indications = 500;

        //inside_continue = GameObject.Find("continue").GetComponent<RectTransform>();

        inside_menu = GameObject.Find("inside_menu").GetComponent<RectTransform>();
        inside_indications = 1000;

        start_menu = GameObject.Find("continue").GetComponent<RectTransform>();
        respawn = GameObject.Find("respawned").GetComponent<RectTransform>();


        crane_left = GameObject.Find("crane_left").GetComponent<RectTransform>();
        crane_right = GameObject.Find("crane_right").GetComponent<RectTransform>();
        cl_ini = crane_left.anchoredPosition.x;
        cr_ini = crane_right.anchoredPosition.x;// = new Vector2(0, start_indications);

        countdown = GameObject.Find("03_time").GetComponent<RectTransform>();
        countdown_ini = cr_ini = crane_right.anchoredPosition.x;

        myflash3d = GameObject.Find("info").GetComponent<RectTransform>();

        // text_health_current = GameObject.Find("health_current").GetComponent<Text>();

        //text_score_current = GameObject.Find("points_current").GetComponent<Text>();
        // text_score_max = GameObject.Find("points_max").GetComponent<Text>();
        // text_score_max.text = parametrii_ego.my_var_4_max.ToString();


        //text_ammo_current = GameObject.Find("ammo_current").GetComponent<Text>();
        //text_ammo_max = GameObject.Find("ammo_max").GetComponent<Text>();
        //text_ammo_max.text = parametrii_ego.my_var_0_max.ToString();



        //weapon_image_0 = GameObject.Find("weapon_images").transform.Find("weapon_0").gameObject;
        //weapons_image.Add(weapon_image_0);
        //weapon_image_1 = GameObject.Find("weapon_images").transform.Find("weapon_1").gameObject;
        //weapons_image.Add(weapon_image_1);
        //weapon_image_2 = GameObject.Find("weapon_images").transform.Find("weapon_2").gameObject;
        //weapons_image.Add(weapon_image_2);

        // aim = GameObject.Find("aim");
        //aim.SetActive(false);
        move_circles = GameObject.Find("ms");

        munitie = GameObject.Find("f5_gun_ammo_bar").GetComponent<Image>();

        
        sanatate = GameObject.Find("action_life_long").GetComponent<Image>();
        //colectat = GameObject.Find("points_current_line").GetComponent<RectTransform>();

        // icon_sanatate = GameObject.Find("health_icon").GetComponent<RectTransform>();

        //compas_all = GameObject.Find("compas_icon").GetComponent<RectTransform>();
        //init_compas = compas_all.anchoredPosition.y;

        /*
        if (SceneManager.GetActiveScene().name != "s1")
        {
            fps.pauza = 1;
        }
        if (SceneManager.GetActiveScene().name == "s1")
        {
            fps.pauza = 0;
        }
        */
        latime_ecran = Screen.height;
        //Debug.Log(latime_ecran);
       
        inside_call = 0;
        crane_non_move();
    }

    public void crane_non_only()
    {
        crane_left.anchoredPosition = new Vector2(cl_ini, 1000.0f);
        //crane_right.anchoredPosition = new Vector2(cr_ini, 1000.0f);
    }

    public void crane_non_move()
    {
        crane_left.anchoredPosition = new Vector2(cl_ini, 1000.0f);
        crane_right.anchoredPosition = new Vector2(cr_ini, 1000.0f);
    }

    public void crane_only()
    {
        crane_left.anchoredPosition = new Vector2(cl_ini, 100.0f);
        //crane_right.anchoredPosition = new Vector2(cr_ini, 180.0f);
    }

    public void crane_move()
    {
        crane_left.anchoredPosition = new Vector2(cl_ini, 100.0f);
        crane_right.anchoredPosition = new Vector2(cr_ini, 180.0f);
    }

    public void countdown_move()
    {
        countdown.anchoredPosition = new Vector2(0.0f, 40.0f);
        //crane_right.anchoredPosition = new Vector2(cr_ini, -180.0f);
    }

    public void countdown_back()
    {
        countdown.anchoredPosition = new Vector2(0.0f, -720.0f);
        //crane_right.anchoredPosition = new Vector2(cr_ini, -180.0f);
    }

    public void myflash3d_move()
    {
        myflash3d.anchoredPosition = new Vector2(0.0f, 40.0f);
        //crane_right.anchoredPosition = new Vector2(cr_ini, -180.0f);
    }

    public void afisare_ammo()
    {
        //text_ammo_current.text = parametrii_ego.my_var_0.ToString();
        //munitie.sizeDelta = new Vector2((parametrii_ego.my_var_0 * 60.0f)/ parametrii_ego.my_var_0_max, munitie.sizeDelta.y);
        amobar = parametrii_ego.my_var_0;
        amomax = parametrii_ego.my_var_0_max;
        //Debug.Log(parametrii_ego.my_var_0);
        munitie.fillAmount = amobar/amomax;
       
    }

    public void afisare_health()
    {      
       // lfobar = parametrii_ego.my_var_3;
      //  lfomax = parametrii_ego.my_var_3_max;
      //  sanatate.fillAmount =  lfobar / lfomax;
    }

    public void afisare_points()
    {
        //text_score_current.text = parametrii_ego.my_var_4.ToString();
        //colectat.sizeDelta = new Vector2((parametrii_ego.my_var_4 * 60.0f) / parametrii_ego.my_var_4_max, munitie.sizeDelta.y);
    }
/*
    public void check_position()
    {
        checkpoint_remark.anchoredPosition = new Vector2(0, check_indications);
        if (check_call == 1)
        {
            check_indications -= (check_indications - 0) / 5;
            check_lov = check_lov + 1;
            if (check_lov >= 100)
            {
                check_call = 0;
            }
        }
        if (check_call == 0)
        {
            check_indications -= (check_indications - 500) / 5;
        }
    }
*/
    public static void check_anunta()
    {
        check_lov = 0;
        check_call = 1;
    }

    public void inside_position()
    {
        
        if (inside_call == 1)
        {
            inside_indications = 0.0f;// latime_ecran * 0.5f;//;
        }

        if (inside_call == 0)
        {
            inside_indications = 1000;
        }
        inside_menu.anchoredPosition = new Vector2(0, inside_indications);
    }

    public void start_position()
    {
        
        if (start_call == 0)
        {
            start_indications = -40;
        }

        if (start_call == 1)
        {
            start_indications =  400;
        }
        start_menu.anchoredPosition = new Vector2(0, start_indications);
    }

    public void respawn_position()
    {

        if (respawn_call == 0)
        {
            respawn_indications = -40;
        }

        if (respawn_call == 1)
        {
            respawn_indications = 400;
        }
        respawn.anchoredPosition = new Vector2(0, respawn_indications);
    }

    public void inside_go_position()
    {
        inside_continue.anchoredPosition = new Vector2(0, inside_continue_y);
        if (inside_y == 0)
        {
            inside_continue_y = 0;
        }

        if (inside_y == 1)
        {
             inside_continue_y = 1000;
        }
    }

    /*
    public void start_go_position()
    {
        inside_continue.anchoredPosition = new Vector2(0, start_continue_y);
        if (start_y == 0)
        {
            start_continue_y = 0;
        }

        if (start_y == 1)
        {
            start_continue_y = 1000;
        }
    }
    */

    public static void inside_anunta()
    {
       // if(start_call == 1)
       // {
            inside_call = 1;
       // }
    }

    public static void inside_renunta()
    {
        inside_call = 0;
    }

    public static void start_anunta()
    {
        start_call = 0;
    }

    public static void start_renunta()
    {
        start_call = 1;
    }

    public static void inside_go()
    {
        inside_y = 1;
        //inside_continue.anchoredPosition = new Vector2(0, 1000.0f);
        //fps.pauza = 0;
    }

    void Update()
    {
        afisare_ammo();
        afisare_health();
        //afisare_points();
        //check_position();
        inside_position();
        start_position();
        respawn_position();
        //inside_go_position();

        //dirLookEgo = GameObject.Find("checkpoint_1").transform.position - GameObject.Find("Capsule").transform.position;
        //dirMers = GameObject.Find("Camera").transform.forward;
        /*
        dirLookEgo = -new Vector3(GameObject.Find("Camera").transform.position.x, 0.0f, GameObject.Find("Camera").transform.position.z) + new Vector3(GameObject.Find("checkpoint_1").transform.position.x, 0.0f, GameObject.Find("checkpoint_1").transform.position.z);
        dirMers = new Vector3(GameObject.Find("Camera").transform.forward.x, 0.0f, GameObject.Find("Camera").transform.forward.z);
        unghi_mers = Vector3.Angle(dirLookEgo, dirMers);
        //Debug.Log(unghi_mers);
        compas_all.anchoredPosition = new Vector2(unghi_mers*2.0f, init_compas);
        */
        //if (by_screen == 1)
        //{
        //move_circles.SetActive(true);
        //}

        // if (by_screen == 0)
        // {
        //move_circles.SetActive(false);
        //}
    }
}

