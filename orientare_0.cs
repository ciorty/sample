using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using ChartboostSDK;

public class orientare_0 : MonoBehaviour {
	public float eotY;
    float eotX;
    float rotX;
	float speedX;
    float spdX;
    float sdZ;
	public static float trage;
	public static float pdaX;
	float pdaY;
	Vector3 dirE;
	float sn;
	float cs; 
	float k;
	float m; 
	GameObject c2;
	GameObject c3;
	public static float fata;
    int lateral;
    int lateral_s;
    int lateral_d;
    float inAir;
    public static float vy;
    float vx;
    float vz;
    public static int once_jump;
    float shootForce;
    public static int once_shoot;
    int once_w;
    //public parametrii_ego variabile;
    public int play_shoot;
    public RaycastHit hitShoot;
    public static int ascunde_mouse;
    public static int pauza;
    public static int from_menu;
    public static int onefall;
    GameObject ast;
    public ParticleSystem die;
    public int layerMask;
    private Vector3 endPoint;
    public RaycastHit hit;
    //public Vector3 dirLookEgo;
    public float rotatia;
    public Quaternion angle;
    public float kb;
    //public animations_ego movings;
    float rotX_init;
    //private Animator animator;
    public animations_ego movings;
    public int jump_on;
    public int once_k;
    public static int atack;

    public static int amortizat;
    public static int contact_cu_obstacol;
    public static int alte_arme;

    public int once_idle;
    public int once_run;
    public int once_right;
    public int once_left;
    public int once_hit;
    public int once_rope;
    public static int din_saritura;

    public int once_change;
    int weapon_mode;
    int hit_once;
    public Rigidbody hj;
    public float rope_up;
    float rope_climb;
    public int once_climb_over;
    public int once_jump_over;
    public int once_pos_reg;

    Vector3 contact_rope;
    public Vector3 new_pos_rigid;

    public int is_vertical;
    int move_up;
    int push_pull;
    int attack_mode;

    public static string action;
    public int re_action;

    float check_over_high;
    int start_jump;
    public static GameObject rope_to_climb;
    public static string game_mode;

    public int stm;
    public int obstacol;
    //float rate_rot;

    public static int mode_change;
    public static int mode_hit;

    string ultimul;

    public int arma;
    //public int parametrii_ego.my_var_0;
    public int gloante_1;
    public int gloante_2;

    GameObject prefabBullet;
    GameObject to_shoot;
    GameObject to_shoot_1;
    GameObject to_shoot_2;
    GameObject to_shoot_3;
    public int once_drag;
    public GameObject gamo;
    public GameObject tamo;

    SpringJoint tempHinge;
    GameObject tam;

    public static GameObject weapon_fight;
    public static GameObject weapon_melee;
    public static GameObject suport_fight_hand;
    public static GameObject suport_melee_hand;
    public static GameObject suport_fight_back;
    public static GameObject suport_melee_back;
    int roteste;
    int one_touch;

    float angle_ini_1;
    float angle_ini_2;


    Vector3 dirLookEgo;
    Vector3 dirMers;

    Vector3 vertical;

    float angle_start;
    float angle_move;


    Ray raytouch;
    RaycastHit hittouch;

    int click_count;

    int depot;

    int executa;

    GameObject particle;
    ParticleSystem stars3;

    GameObject particle4;
    ParticleSystem stars4;

    public GameObject prefabSound_no_ammo;
    public GameObject prefabSound_0;
    public GameObject prefabSound_1;
    public GameObject prefabSound_2;
    public GameObject prefabSound_3;
    //public GameObject prefabSound_4;

    int reloaded;

    int jump_action;
    int jump_q;

    Vector3 before;
    Vector3 after;
    Vector3 dis_up;

    int die_once;

    GameObject fade_0;

    public float rel_x;
    public float rel_y;
    public float rel_z;
    public float curent_cut;
    SoftJointLimit limit_sup;

    GameObject pos_anchor;
    public static string re_place;

    int stop_force;

    public static float rate_rot;

    Color ceva;
    GameObject cam_main;
    public Texture handmouse;

    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.Auto;
    //public Vector2 hotSpot = Vector2.zero;
    public int muscat;
    int onc_int;
    int cache_once;



    //pauza
    //_____________________________________

    void Awake()
    {
        Application.targetFrameRate = 40;
        RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fog = true;
        RenderSettings.fogMode = FogMode.Linear;
        RenderSettings.fogStartDistance = 60.0f;
        RenderSettings.fogEndDistance = 90.0f;
        //Input.multiTouchEnabled = false;


        

    }

    void Start () {

        //Chartboost.cacheInterstitial(CBLocation.Default);
       // Chartboost.cacheRewardedVideo(CBLocation.Default);
        //cursorTexture = (Texture2D)Resources.Load("hndmouse", typeof(Texture2D));
        // Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        cam_main = GameObject.Find("Camera");
        cam_main.GetComponent<Camera>().backgroundColor = RenderSettings.fogColor;
        cam_main.GetComponent<Camera>().farClipPlane = RenderSettings.fogEndDistance = 90.0f;
        //Debug.Log(ceva);
        pdaX = 0;
        stop_force = 0;
        re_place = "atentionare_end";
        pos_anchor = new GameObject();
        die_once = 0;
        pauza = 2;
        arma = 0;
        //parametrii_ego.my_var_0 = 6;
        obstacol = 1;
        action = "ego_idle";
        kb = 0.6f;
        inAir = 1.0f;
        m = new float();
        m = 0.0f;
        k = new float();
        k = 0.0f;
        c2 = GameObject.Find("cont2");
        c3 = GameObject.Find("cont3");
        rotX_init = c2.transform.localEulerAngles.x;
        //rotX = rotX_init;
        movings = GetComponent<animations_ego>();
        fata = 0;
        atack = 0;
        once_jump = 0;
        weapon_mode = 0;
        if (atack == 0) { weapon_mode = 250; }
        if (atack == 1) { weapon_mode = 320; }
        if (atack == 2) { weapon_mode = 350; }
        game_mode = "climb";// move // fight // pick // climb // melee
        stm = 0;
       rate_rot = 0.4f;

        fade_0 = GameObject.Find("perdea");

        prefabBullet = (GameObject)Resources.Load("bullet_ego_weapon_1", typeof(GameObject));
        to_shoot = GameObject.Find("shoot_dummie");
        to_shoot_1 = GameObject.Find("shoot_dummie_1");
        to_shoot_2 = GameObject.Find("shoot_dummie_2");
        to_shoot_3 = GameObject.Find("shoot_dummie_3");
        if (!Application.isMobilePlatform)
        {
            kb = 0.8f;
        }

        weapon_melee = GameObject.Find("weapon_melee");
        suport_melee_hand = GameObject.Find("w_melee_hand");
        suport_melee_back = GameObject.Find("w_melee_back");

        weapon_fight = GameObject.Find("weapon_fight");
        suport_fight_hand = GameObject.Find("w_fight_hand");
        suport_fight_back = GameObject.Find("w_fight_back");
        dirMers = new Vector3(0, 1, 0);


        particle = (GameObject)Resources.Load("WFX_BImpact Sand", typeof(GameObject));
        //stars3 = particle.GetComponent<ParticleSystem>();
        particle4 = (GameObject)Resources.Load("BloodMist", typeof(GameObject));
        //stars4 = particle4.GetComponent<ParticleSystem>();

        // GameObject ast = (GameObject)Resources.Load("groundLight", typeof(GameObject));
        //die = ast.GetComponent<ParticleSystem>();

        prefabSound_no_ammo = (GameObject)Resources.Load("ego_no_ammo_sound", typeof(GameObject));
        prefabSound_0 = (GameObject)Resources.Load("ego_shoot_0_sound", typeof(GameObject));
        prefabSound_1 = (GameObject)Resources.Load("ego_shoot_1_sound", typeof(GameObject));
        prefabSound_2 = (GameObject)Resources.Load("ego_shoot_2_sound", typeof(GameObject));
        prefabSound_3 = (GameObject)Resources.Load("ego_shoot_0_sound", typeof(GameObject));
        //prefabSound_4 = (GameObject)Resources.Load("impact_0_sound", typeof(GameObject));
        eotX = 10.0f;
        rotX = 10.0f;

        vy = 0.0f;
        react.start_count = 0;
        react.sec = 18100;
        react.min = 0;
        react.hou = 0;

        //manager_hud_script.test_mouse.transform.position = new Vector3(0, -200.0f, 0);

    }

    void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           // fata = 0;
          //  lateral = 0;
          //  lateral_s = 0;
          //  lateral_d = 0;
        }
    }

    //_____________________________________

    void impulse_up()
    {
        GetComponent<Rigidbody>().AddForce(0, 90, 0, ForceMode.Impulse);
    }

    void hit_from_aim()
    {
        hit_once = 0;
    }

    void shoot_from_aim()
    {
        gloanteGenerator();
    }

    void coord_imputs()
    {
        if (!Application.isMobilePlatform)
        {
            if (Input.GetKeyDown(KeyCode.W)) { fata = 1; }
            if (Input.GetKeyUp(KeyCode.W)) { fata = 0; }
            if (Input.GetKeyDown(KeyCode.S)) { fata = -1; }
            if (Input.GetKeyUp(KeyCode.S)) { fata = 0; }
            if (Input.GetKeyDown(KeyCode.A)) { lateral = 1; }
            if (Input.GetKeyUp(KeyCode.A)) { lateral = 0; }
            if (Input.GetKeyDown(KeyCode.D)) { lateral = -1; }
            if (Input.GetKeyUp(KeyCode.D)) { lateral = 0; }
        }

        if (Application.isMobilePlatform)
        {
            if (butt_left.apasat == 1) { lateral = 1; }
            if (butt_right.apasat == 1) { lateral = -1; }
            if (butt_left.apasat == 0 && butt_right.apasat == 0){lateral = 0;}



            if (butt_foreward.apasat == 1) { fata = 1; }
            if (butt_bw.apasat == 1) { fata = -1; }

            if (butt_bw.apasat == 0 && butt_foreward.apasat == 0){fata = 0;}
            if (butt_bw.apasat == 1 && butt_foreward.apasat == 1) { fata = 1; }
            if (butt_bw.apasat == 0 && butt_foreward.apasat == 1) { fata = 1; }
            if (butt_bw.apasat == 1 && butt_foreward.apasat == 0) { fata = -1; }
        }

        if (Input.GetKeyDown(KeyCode.Space) ||  butt_action.apasat == 1)
        {
            if (once_jump_over == 0)
            {
                if(action == "ego_idle" ||
                    action == "ego_run" ||
                    action == "ego_push" ||
                    action == "ego_drag" ||
                    action == "ego_back"
                    )
                actiune();
                once_jump_over = 1;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) || butt_action.apasat == 0)
        {
            once_jump_over = 0;
        }
    }
    // Feel
    void actiune()
    {

        if (game_mode == "pick")
        {
            //mode_hit = 1;
            //Invoke("hit_from_aim", 0.5f);
            game_mode = "climb";
        }
        if (Trg.inContact == 1)
        {
            

            
            if (game_mode == "climb")
            {
                if (fata == 0)
                {
                    action = "ego_jump_from_stand";
                   // Invoke("impulse_up", 0.2f);
                    GetComponent<Rigidbody>().AddForce(0, 100, 0, ForceMode.Impulse);
                }
                if (fata == 1)
                {
                    action = "ego_jump_from_move";
                    //Invoke("impulse_up", 0.0f);
                    GetComponent<Rigidbody>().AddForce(0, 100, 0, ForceMode.Impulse);
                }
                if (fata == -1)
                {
                    action = "ego_jump_from_move";
                    //Invoke("impulse_up", 0.0f);
                    GetComponent<Rigidbody>().AddForce(0, 100, 0, ForceMode.Impulse);
                }
            }

            if (game_mode == "melee")
            {
                if (once_hit == 0)
                {
                    Invoke("pune", 0.2f);
                    Invoke("repune", 0.5f);
                    once_hit = 1;
                }
                mode_hit = 1;
                Invoke("hit_from_aim", 0.5f);
            }

            if (game_mode == "fight")
            {
                //if (parametrii_ego.my_var_0 > 0)//daca mai exista gloante
                //{
                if (reloaded == 0)//daca a trecut timpul necesar incarcarii
                {
                    if (parametrii_ego.my_var_0 > 0)//daca mai sunt gloante
                    {
                        mode_hit = 1;
                    }

                    gloanteGenerator();
                    //reloaded = 1;//mai pot trage doar dupa ce devine din nopu zero
                }
                //}
            }

       }
    }

    void pune()
    {

        melee_ego.once = 0;

    }

    void repune()
    {
        melee_ego.once = 1;
        once_hit = 0;

    }

    void incarca()
    {
        reloaded = 0;

    }
   
    public void gloanteGenerator()
    {
        //__________________________________________________________________________________________________________________________

        if (arma == 0 && parametrii_ego.my_var_0 == 0)
        {
            
            GameObject instanceSound_no_ammo;
            instanceSound_no_ammo = Instantiate(prefabSound_no_ammo, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            Destroy(instanceSound_no_ammo, 2.0f);
            
        }

        if (arma == 0 && parametrii_ego.my_var_0 > 0)
        {
           
            //GameObject instanceMuzzle;
            //instanceMuzzle = Instantiate(prefabMuzzle, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            //Destroy(instanceMuzzle, 0.05f);
            parametrii_ego.my_var_0 = parametrii_ego.my_var_0 - 1; if (parametrii_ego.my_var_0 <= 0){parametrii_ego.my_var_0 = 0;}
            
            GameObject instanceSound_0;
            instanceSound_0 = Instantiate(prefabSound_0, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            Destroy(instanceSound_0, 2.0f);
            
            GameObject instanceBullet1;
            instanceBullet1 = Instantiate(prefabBullet, to_shoot_1.transform.position, to_shoot_1.transform.rotation) as GameObject;
            shootForce = 800;
            instanceBullet1.GetComponent<Rigidbody>().mass = 0.5f;
            instanceBullet1.GetComponent<Rigidbody>().AddForce(to_shoot_1.transform.forward * shootForce);
            Destroy(instanceBullet1, 1.0f);
            /*
            GameObject instanceBullet2;
            instanceBullet2 = Instantiate(prefabBullet, to_shoot_2.transform.position, to_shoot_2.transform.rotation) as GameObject;
            shootForce = 10000;
            instanceBullet2.GetComponent<Rigidbody>().mass = 5;
            instanceBullet2.GetComponent<Rigidbody>().AddForce(to_shoot_2.transform.forward * shootForce);
            Destroy(instanceBullet2, 1.0f);

            GameObject instanceBullet3;
            instanceBullet3 = Instantiate(prefabBullet, to_shoot_3.transform.position, to_shoot_3.transform.rotation) as GameObject;
            shootForce = 10000;
            instanceBullet3.GetComponent<Rigidbody>().mass = 5;
            instanceBullet3.GetComponent<Rigidbody>().AddForce(to_shoot_3.transform.forward * shootForce);
            Destroy(instanceBullet3, 1.0f);
            */
            reloaded = 1;
            Invoke("incarca", 0.8f);
           
            
        }

        //__________________________________________________________________________________________________________________________

        if (arma == 1 && gloante_1 == 0)
        {
            /*
            GameObject instanceSound_no_ammo;
            instanceSound_no_ammo = Instantiate(prefabSound_no_ammo, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            Destroy(instanceSound_no_ammo, 2.0f);
            */
        }

        if (arma == 1 && gloante_1 > 0)
        {
            if (play_shoot == 1)
            {
                /*
                GameObject instanceMuzzle;
                instanceMuzzle = Instantiate(prefabMuzzle, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
                Destroy(instanceMuzzle, 0.05f);
                gloante_1 = gloante_1 - 1; if (gloante_1 <= 0){gloante_1 = 0;}

                GameObject instanceSound_1;
                instanceSound_1 = Instantiate(prefabSound_1, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
                Destroy(instanceSound_1, 2.0f);
                */
                GameObject instanceBullet;
                instanceBullet = Instantiate(prefabBullet, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
                shootForce = 3000;
                instanceBullet.GetComponent<Rigidbody>().mass = 1;
                instanceBullet.GetComponent<Rigidbody>().AddForce(c3.transform.forward * shootForce);
                Destroy(instanceBullet, 1.0f);
                //if (pauza == 0)
                //{
                    Invoke("gloanteGenerator", 0.11f);
                //}
            }
        }

        //__________________________________________________________________________________________________________________________

        if (arma == 2 && gloante_2 == 0)
        {
            /*
            GameObject instanceSound_no_ammo;
            instanceSound_no_ammo = Instantiate(prefabSound_no_ammo, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            Destroy(instanceSound_no_ammo, 2.0f);
            */
        }

        if (arma == 2 && gloante_2 > 0)
        {
            /*
            GameObject instanceMuzzle;
            instanceMuzzle = Instantiate(prefabMuzzle, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            Destroy(instanceMuzzle, 0.05f);
            gloante_2 = gloante_2 - 1; if (gloante_2 <= 0){gloante_2 = 0;}

            GameObject instanceSound_2;
            instanceSound_2 = Instantiate(prefabSound_2, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            Destroy(instanceSound_2, 2.0f);
            */
            GameObject instanceBullet;
            instanceBullet = Instantiate(prefabBullet, to_shoot.transform.position, to_shoot.transform.rotation) as GameObject;
            shootForce = 4000;
            instanceBullet.GetComponent<Rigidbody>().mass = 1;
            instanceBullet.GetComponent<Rigidbody>().AddForce(c3.transform.forward * shootForce);
            Destroy(instanceBullet, 1.0f);

            Invoke("incarca", 0.5f);
        }
    }

    void rotations()
    {

        //________________________________________________________________________________________________________________

        if (!Application.isMobilePlatform)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (Input.mousePosition.x > Screen.width / 2)
                {
                    if (trage == 0)
                    {
                        k = pdaX - Input.mousePosition.x;
                        m = pdaY - Input.mousePosition.y;
                        before = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
                        jump_q = 1;
                        trage = 1;
                    }
                }
            }
        }

        if (Application.isMobilePlatform)
        {
            for (var i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).position.x > Screen.width / 2)
                {
                    if (trage == 0)
                    {
                        k = pdaX - Input.GetTouch(i).position.x; //pdaX - Input.mousePosition.x ; 
                        m = pdaY - Input.GetTouch(i).position.y; //pdaY - Input.mousePosition.y ;
                        before = new Vector3(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y, 0);
                        jump_q = 1;
                        trage = 1;
                    }
                }
            }
        }

        //________________________________________________________________________________________________________________

        if (!Application.isMobilePlatform)
        {
            if (Input.GetMouseButtonUp(0))
            {

                //if (Input.mousePosition.x > Screen.width / 2)
                //{
                    manager_hud_script.test_mouse.transform.position = new Vector3(0, -200.0f, 0);
                    jump_q = 0;
                    if (jump_action < 4 && jump_action > 0)
                    {
                        dis_up = after - before;
                        //Debug.Log(dis_up.magnitude);
                       if (dis_up.magnitude < 2.0f)
                        {
                            //actiune();
                        }
                    }
                    jump_action = 0;
                    trage = 0;
                //}
            }
        }

        if (Application.isMobilePlatform)
        {
            for (var i = 0; i < Input.touchCount; ++i)
            {
                if (Input.GetTouch(i).position.x > Screen.width / 2)
                {
                    if (Input.GetTouch(i).phase == TouchPhase.Ended)
                    {
                        manager_hud_script.test_mouse.transform.position = new Vector3(0, -200.0f, 0);
                        jump_q = 0;
                        if (jump_action < 4 && jump_action > 0)
                        {
                            dis_up = after - before;
                            if (dis_up.magnitude < 2.0f)
                            {
                                //actiune();
                            }
                        }
                        jump_action = 0;
                        trage = 0;
                    }
                }
            }
        }

        //________________________________________________________________________________________________________________

        if (trage == 1)
        {
            if (!Application.isMobilePlatform)
            {
                pdaX = Input.mousePosition.x + k;
                manager_hud_script.test_mouse.transform.position = Input.mousePosition;
                after = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            }

            if (Application.isMobilePlatform)
            {
                for (var i = 0; i < Input.touchCount; ++i)
                {
                    if (Input.GetTouch(i).position.x > Screen.width / 2)
                    {
                        pdaX = Input.GetTouch(i).position.x + k;
                        manager_hud_script.test_mouse.transform.position = new Vector2(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y);
                        after = new Vector3(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y, 0);
                    }
                }
            }
        }


        jump_action = jump_action + jump_q;

        //rotX -= (rotX + pdaY / 2 + 40) / 2;
        eotY -= (eotY - pdaX *rate_rot) *0.3f;



        c3.transform.localEulerAngles = new Vector3(0.0f, eotY, 0.0f);
        


        dirE.x = 350 * fata * obstacol * c3.transform.forward.x - 250 * lateral * c3.transform.right.x;
        dirE.y = 0;
        dirE.z = 350 * fata * obstacol * c3.transform.forward.z - 250 * lateral * c3.transform.right.z;
    }

    void force_horizontal()
    {
        if(start_jump == 0)
        {
            if (Trg.inContact == 1) { inAir = 1.0f; }
            if (Trg.inContact == 0) { inAir = 1.5f; }
        }

        if (start_jump == 1)
        {
             inAir = 2.0f; 
        }

       // vx = GetComponent<Rigidbody>().velocity.x;
        //vz = GetComponent<Rigidbody>().velocity.z;


        if (Trg.inViteza == 0)
        {
            vx = GetComponent<Rigidbody>().velocity.x - Trg.stand.GetComponent<Rigidbody>().velocity.x;
            vz = GetComponent<Rigidbody>().velocity.z - Trg.stand.GetComponent<Rigidbody>().velocity.z;
        }

        if (Trg.inViteza == 1)
        {
            vx = GetComponent<Rigidbody>().velocity.x;
            vz = GetComponent<Rigidbody>().velocity.z;
        }

        GetComponent<Rigidbody>().AddForce(2.7f * dirE.x, 0, 2.7f * dirE.z);
        GetComponent<Rigidbody>().AddForce(-vx * 120 * inAir, 0, -vz * 120 * inAir);
    }

    //_____________________________________

    void move_to_top_pos()
    {
        Feel.inContact = 2;
        Feel_top.inTop = 0;
    }
    void move_up_stop()
    {
        move_up = 1;
        movings.over_to_stabile();
    }

    void remove()
    {
        Feel.inContact = 0;
    }

    void is_kinematic()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().isTrigger = true;
        transform.Find("Capsule").GetComponent<Collider>().isTrigger = true; 
        transform.Find("falling_cone").GetComponent<Collider>().isTrigger = true;
    }

    void is_rigid()
    {
        gameObject.GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Collider>().isTrigger = false;
        transform.Find("Capsule").GetComponent<Collider>().isTrigger = false;
        transform.Find("falling_cone").GetComponent<Collider>().isTrigger = false;
    }

    void ego_change_weapon()
    {
        if (action == "ego_change_weapon")
        {
            is_kinematic();
           if(Feel_med.stand)
            {
                rel_x = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.x * curent_cut;
                rel_y = 0.0f;
                rel_z = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.z * curent_cut;
            }


           transform.position = transform.position + new Vector3(rel_x, rel_y, rel_z);

            if (movings.once != "neutru_change_weapon") { movings.once = "change_weapon"; }

            if (once_climb_over == 0)
            {
                Invoke("reput", 0.6f);
                once_climb_over = 1;
            }
        }
    }

    void ego_hit()
    {
        if (action == "ego_hit")
        {
            is_kinematic();
            if (Feel_med.stand)
            {
                rel_x = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.x * curent_cut;
                rel_y = 0.0f;
                rel_z = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.z * curent_cut;
            }


            transform.position = transform.position + new Vector3(rel_x, rel_y, rel_z);
            if (movings.once != "neutru_hit") { movings.once = "hit"; }
            if (once_climb_over == 0)
            {
                Invoke("reput", 0.8f);
                once_climb_over = 1;
            }
        }
    }

    void reput()
    {
        action = ultimul;
    }

    void m_move()
    {
        if (Feel_top.inTop == 0 && Feel_med.inContact == 0)
        {
            if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_run"; obstacol = 1; }
            if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_run"; obstacol = 1; }
            if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_run"; obstacol = 1; }
            if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 1; }
            if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 1; }
            if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 1; }
            if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
            if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
            if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
            if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
            if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
                GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
            }
        }



        if (Feel_top.inTop == 0 && Feel_med.inContact == 1)
        {
            if (game_mode != "pick")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }

                if (tempHinge)
                {
                    Destroy(tempHinge);
                    once_drag = 0;
                    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                }
            }

            if (game_mode == "pick")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }
            }
        }



        if (Feel_top.inTop == 1 && Feel_med.inContact == 0)
        {
            if(game_mode == "move" || game_mode == "melee" || game_mode == "fight")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }

                if (tempHinge) {
                    Destroy(tempHinge);
                    once_drag = 0;
                    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                }
            }

            if (game_mode == "pick")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }
            }

            if (game_mode == "climb")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_climb_edge_over_low"; obstacol = 1; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_climb_edge_over_low"; obstacol = 1; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_climb_edge_over_low"; obstacol = 1; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }

                if (tempHinge)
                {
                    Destroy(tempHinge);
                    once_drag = 0;
                    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                }
            }
        }

        if (Feel_top.inTop == 1 && Feel_med.inContact ==1)
        {
            if (game_mode == "move" || game_mode == "melee" || game_mode == "fight")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }

                if (tempHinge)
                {
                    Destroy(tempHinge);
                    once_drag = 0;
                    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                }
            }

            if (game_mode == "pick")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_push"; obstacol = 1; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_drag"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }
            }

            if (game_mode == "climb")
            {
                if (fata == 1 && lateral == 0) { once_climb_over = 0; action = "ego_climb_edge_over_low"; obstacol = 1; }
                if (fata == 1 && lateral == 1) { once_climb_over = 0; action = "ego_climb_edge_over_low"; obstacol = 1; }
                if (fata == 1 && lateral == -1) { once_climb_over = 0; action = "ego_climb_edge_over_low"; obstacol = 1; }
                if (fata == 0 && lateral == 0) { once_climb_over = 0; action = "ego_idle"; obstacol = 0; }
                if (fata == 0 && lateral == 1) { once_climb_over = 0; action = "ego_left"; obstacol = 0; }
                if (fata == 0 && lateral == -1) { once_climb_over = 0; action = "ego_right"; obstacol = 0; }
                if (fata == -1 && lateral == 0) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == 1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (fata == -1 && lateral == -1) { once_climb_over = 0; action = "ego_back"; obstacol = 1; }
                if (mode_change == 1) { once_climb_over = 0; ultimul = action; action = "ego_change_weapon"; mode_change = 0; obstacol = 0; }
                if (mode_hit == 1) { once_climb_over = 0; ultimul = action; action = "ego_hit"; mode_hit = 0; obstacol = 0; }

                if (tempHinge)
                {
                    Destroy(tempHinge);
                    once_drag = 0;
                    GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
                }
            }
        }


        
        if (Feel.inContact == 1)
        {
            if (game_mode == "move") { once_climb_over = 0; action = "ego_idle"; }
            if (game_mode == "melee") { once_climb_over = 0; action = "ego_idle"; }
            if (game_mode == "fight") { once_climb_over = 0; action = "ego_idle"; }
            if (game_mode == "pick") { once_climb_over = 0; action = "ego_idle"; }
            if (game_mode == "climb") { once_climb_over = 0; action = "ego_climb_rope"; }
        }

        if (Trg.inContact == 0)
        {
            once_climb_over = 0; action = "ego_fall_stand";
        }
    }

   
    public void ego_die()
    {
        if (action == "ego_die")
        {
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_die") { movings.once = "die"; }
            m_move();

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_idle()
    {
        if (action == "ego_idle")
        {
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_idle"){ movings.once = "idle";}
            m_move();

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_push()
    {
        if (action == "ego_push")
        {

            /*
                if (Feel_med.collision_call.name != "schela_mare")
                {
                    if (once_drag == 0)
                    {
                        tam = Feel_med.collision_call.gameObject;
                        pos_anchor.transform.position = Feel_med.ctc;
                        pos_anchor.transform.parent = tam.transform;
                        tempHinge = new SpringJoint();
                        tempHinge = tam.AddComponent<SpringJoint>();
                        tempHinge.connectedBody = GetComponent<Rigidbody>();
                        tempHinge.anchor = pos_anchor.transform.localPosition;
                        tempHinge.damper = 0f;
                        tempHinge.spring = 1000f;

                    once_drag = 1;
                    }
                }
*/

            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_push") { movings.once = "push"; }
            m_move();

           // if (Trg.inContact == 0)
           // {
                if (tempHinge)
                {
                    Destroy(tempHinge);
                    once_drag = 0;

                }
            //}
        }
    }

    public void ego_drag()
    {
        if (action == "ego_drag")
        {
            if (once_drag == 0)
            {
                if (Feel_med.collision_call)
                {
                    tam = Feel_med.collision_call.gameObject;
                    pos_anchor.transform.position = Feel_med.ctc;
                    pos_anchor.transform.parent = tam.transform;
                    tempHinge = new SpringJoint();
                    tempHinge = tam.AddComponent<SpringJoint>();
                    tempHinge.connectedBody = GetComponent<Rigidbody>();
                    tempHinge.anchor = pos_anchor.transform.localPosition;
                    tempHinge.damper = 0f;
                    tempHinge.spring = 10000f;
                }
                once_drag = 1;
            }

            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_drag") { movings.once = "drag"; }
            m_move();
        }

        if (Trg.inContact == 0)
        {
            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;

            }
        }
    }

    public void ego_run()
    {
        if (action == "ego_run")
        {
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_run") { movings.once = "run"; }
            m_move();

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }  
    }

    public void ego_left()
    {
        if (action == "ego_left")
        {
            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;

            }
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_left") { movings.once = "left"; }
            m_move();

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_right()
    {
        if (action == "ego_right")
        {
                        if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
               
            }
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_right") { movings.once = "right"; }
            m_move();

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_back()
    {
        if (action == "ego_back")
        {
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_back"){movings.once = "back";}
            m_move();

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_fall_stand()
    {
        if (action == "ego_fall_stand")
        {
            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;

            }
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_fall_stand") { movings.once = "fall_stand"; }
            if (Trg.inContact == 1)
            {
                once_climb_over = 0;
                action = "ego_land";
            }

            if (Feel_top.inTop == 1)
            {
                if(game_mode == "climb")
                {
                    once_climb_over = 0;
                    action = "ego_climb_edge_over_high";
                }
            }

            if (Feel.inContact == 1)
            {
                if (game_mode == "climb")
                {
                    once_climb_over = 0;
                    action = "ego_climb_rope";
                }
            }

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_fall_move()
    {
        if(action == "ego_fall_move")
        {
            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;

            }
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_fall_move") { movings.once = "fall_move"; }
            if(Trg.inContact == 1)
            {
                once_climb_over = 0;
                action = "ego_land";
            }
            if (Feel_top.inTop == 1)
            {
                if (game_mode == "climb")
                {
                    once_climb_over = 0;
                    action = "ego_climb_edge_over_high";
                }
            }

            if (Feel.inContact == 1)
            {
                if (game_mode == "climb")
                {
                    once_climb_over = 0;
                    action = "ego_climb_rope";
                }
            }

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_land()
    {
        if (action == "ego_land")
        {
            is_rigid();
            if (movings.once != "neutru_land") { movings.once = "land"; }
            Invoke("idle_invoke", 0.1f);
            once_climb_over = 1;
        }
    }

    public void ego_jump_from_stand()
    {
        if (action == "ego_jump_from_stand")
        {
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_jump_from_stand") { movings.once = "jump_from_stand"; }

            if (Trg.inContact == 0)
            {
                once_climb_over = 0;
                action = "ego_fall_stand";
            }

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_jump_from_move()
    {
        if (action == "ego_jump_from_move")
        {
            is_rigid();
            force_horizontal();
            if (movings.once != "neutru_jump_from_move") { movings.once = "jump_from_move"; }

            if (Trg.inContact == 0)
            {
                once_climb_over = 0;
                action = "ego_fall_move";
            }

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    void idle_invoke()
    {
        once_climb_over = 0;
        Feel_top.inTop = 0;
        action = "ego_idle";
    }

    public void ego_climb_edge_over_low()
    {
        if (action == "ego_climb_edge_over_low")
        {
            is_kinematic();
            if (movings.once != "neutru_climb_over_low") { movings.once = "climb_over_low"; }
            if (once_climb_over == 0)
            {
                check_over_high = transform.position.y;//inregistrez pozitia pe verticala unde s-a produs contactul cu freza
                once_climb_over = 1;
            }

            //transform.position = transform.position + new Vector3(0, 0.06f, 0);//incepe urcarea
            if (Feel_med.stand)
            {
                rel_x = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.x * curent_cut;
                rel_y = Time.deltaTime * 3;
                rel_z = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.z * curent_cut;
            }


            transform.position = transform.position + new Vector3(rel_x, rel_y, rel_z);//incepe urcarea
            //transform.Translate(0, Time.deltaTime * 4 + 0.2f * Feel_med.collision_call.gameObject.transform.GetComponent<Rigidbody>().velocity.y, 0.0f);
            //transform.Translate(0, Time.deltaTime * 4, 0.0f);
            if (transform.position.y >= check_over_high + 2.2f)
            {
                Feel_top.inTop = 2;//none action
                once_climb_over = 0;
                action = "ego_over_to_stabile";
            }
            
            if (Feel_down.inDown == 0)
            {
               once_climb_over = 0;
               action = "ego_fall_stand";
            }

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_climb_edge_over_high()
    {
        if (action == "ego_climb_edge_over_high")
        {
            is_kinematic();
            if (movings.once != "neutru_climb_over_high") { movings.once = "climb_over_high"; }
            if (once_climb_over == 0)
            {
                check_over_high = transform.position.y;//inregistrez pozitia pe verticala unde s-a produs contactul cu freza
                once_climb_over = 1;
            }

            if (Feel_med.stand)
            {
                rel_x = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.x * curent_cut;
                rel_y = Time.deltaTime * 3;
                rel_z = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.z * curent_cut;
            }



            transform.position = transform.position + new Vector3(rel_x, rel_y, rel_z);//incepe urcarea
            //transform.Translate(0, Time.deltaTime * 2 + 0.2f * Feel_med.collision_call.gameObject.transform.GetComponent<Rigidbody>().velocity.y, 0.0f);
            //transform.Translate(0, Time.deltaTime * 2, 0.0f);
            if (transform.position.y >= check_over_high + 2.2f)
            {
                Feel_top.inTop = 2;//none action
                once_climb_over = 0;
                action = "ego_over_to_stabile";
            }

            if (Feel_down.inDown == 0)
            {
                once_climb_over = 0;
                action = "ego_fall_stand";
            }

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_over_to_stabile()
    {
        if (action == "ego_over_to_stabile")
        {
            is_kinematic();
            if (movings.once != "neutru_over_to_stabile") { movings.once = "over_to_stabile"; }

            if (once_climb_over == 0)
            {
                new_pos_rigid = GameObject.Find("new_rigid").transform.position;
                //once_rope = 0;
                Invoke("idle_invoke", 0.3f);
                once_climb_over = 1;
            }
            // transform.position = new_pos_rigid;
            if (Feel_med.stand)
            {
                rel_x = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.x * 18 * curent_cut;
                rel_y = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.y * 18 * curent_cut;
                rel_z = Feel_med.stand.gameObject.transform.GetComponent<Rigidbody>().velocity.z * 18 * curent_cut;
            }


            transform.position = Vector3.Lerp(transform.position, new_pos_rigid + new Vector3(rel_x, rel_y, rel_z), 0.1f);
            // transform.position = transform.position + transform.forward * 0.02f;

            //if (Vector3.Distance(transform.position, new_pos_rigid) >= 0.4f)
            //{
            //action = "ego_idle";
            //}

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_climb_rope()
    {
        if (action == "ego_climb_rope")
        {
            is_kinematic();

            if(Feel.climb_mode == "rope")
            {
                if (movings.once != "neutru_rope_climbing") { movings.once = "rope_climbing"; }
            }

            if (Feel.climb_mode == "ladder")
            {
                if (movings.once != "neutru_ladder_climbing") { movings.once = "ladder_climbing"; }
            }


            if (once_climb_over == 0)
            {
                check_over_high = transform.position.y;//inregistrez pozitia pe verticala unde s-a produs contactul cu freza

                rope_up = 0;
                contact_rope = new Vector3(rope_to_climb.transform.position.x, transform.position.y, rope_to_climb.transform.position.z);

                once_climb_over = 1;
            }
            //transform.position = contact_rope + new Vector3(0, rope_up, 0);//avansul -> incepe la schimbarea lui rope_up

            transform.position = Vector3.Lerp(transform.position, contact_rope + new Vector3(0, rope_up, 0), 0.1f);
            rope_up = rope_up + 0.04f;
            //transform.position = transform.position + new Vector3(0, 0.05f, 0);//incepe urcarea
            

            
            if (Feel_top.inTop == 1)
            {
                once_climb_over = 0;
                action = "ego_climb_edge_over_high";
            }
            
            if (Feel.inContact == 0 && Feel_med.inContact == 0)
            {
                once_climb_over = 0;
                action = "ego_fall_stand";
            }

            /*
            
            if (transform.position.y >= check_over_high + 2.0f)
            {
                Feel_top.inTop = 2;//none action
                once_climb_over = 0;
                action = "ego_over_to_stabile";
            }

            if (Feel_down.inDown == 0)
            {
                once_climb_over = 0;
                action = "ego_fall_stand";
            }
            */

            if (tempHinge)
            {
                Destroy(tempHinge);
                once_drag = 0;
            }
        }
    }

    public void ego_climb_leader()
    {
        if (action == "ego_climb_leader")
        {

        }
    }

    public void die_and_reload()
    {
        //Chartboost.cacheInterstitial(CBLocation.Default);
        fade_0.GetComponent<Image>().CrossFadeAlpha(1.0f, 1.0f, false);
       
        Invoke("catre_nivelul", 1.5f);
        Invoke("respawned", 2.0f);
        //Invoke("add", 1.0f);
    }

    void add()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        /*
        Mychart.once = 0;

        if (Mychart.conectat == 0)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("05_level_checkpoints");
        }
        if (Mychart.conectat == 1)
        {
            pauza = 0;
            Mychart.once = 0;
        }
        */
    }

    void respawned()
    {
       manager_hud_script.respawn_call = 1;
        pauza = 0;
    }

    void catre_nivelul()
    {
        //onc_int = 0;
        /*
        if(Mychart.conectat == 0)
        {
            SceneManager.LoadScene("05_level_checkpoints");
        }
        */
        //if(Mychart.conectat == 1)
        //{
            //Mychart.once = 0;
            manager_hud_script.respawn_call = 0;
            muscat = 0;
            parametrii_ego.my_var_3 = parametrii_ego.my_var_3_max;

            transform.position = GameObject.Find(re_place).transform.position;
            vy = 0.0f;
            pauza = 2;
            action = "ego_idle";
            die_once = 0;
            fade_0.GetComponent<type>().re_fade();
            trage = 0;

            if (points_0_pick.final_declansat == 0)
            {
                react.start_count = 0;
            }
            if (points_0_pick.final_declansat == 1)
            {
                react.start_count = 1;
            }

            react.sec = 18100;
            react.min = 0;
            react.hou = 0;
       // }
    }


    public void die_and_reload_2()
    {
        //parametrii_ego.my_prov_4 = parametrii_ego.my_prov_4 - 50;
        //GameObject get_points = Instantiate(take_points, transform.position, Quaternion.identity) as GameObject;
        //Destroy(get_points, 3.0f);
        //if (parametrii_ego.my_prov_4 <= 0)
        //{
        //    parametrii_ego.my_prov_4 = 0;
        // }
        //pauza = 1;
        //orientare_1.shooted = 1;

        //fade_0.GetComponent<Image>().CrossFadeAlpha(1.0f, 1.0f, false);
        
        Invoke("catre_stai", 10.0f);
    }

    void catre_stai()
    {
        
        fade_0.GetComponent<Image>().CrossFadeAlpha(1.0f, 1.0f, false);
        Invoke("catre_nivelul_2", 1.0f);
    }

    void catre_nivelul_2()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        muscat = 0;
        parametrii_ego.my_var_3 = parametrii_ego.my_var_3_max;
        transform.position = GameObject.Find(re_place).transform.position;
        vy = 0.0f;
        pauza = 0;
        action = "ego_idle";
        die_once = 0;
        fade_0.GetComponent<type>().re_fade();
        trage = 0;

        if (points_0_pick.final_declansat == 0)
        {
            react.start_count = 0;
        }
        if (points_0_pick.final_declansat == 1)
        {
            react.start_count = 1;
        }
        react.sec = 18100;
        react.min = 0;
        react.hou = 0;

        if (GameObject.Find("nuke_light(Clone)"))
        {
            Destroy(GameObject.Find("nuke_light(Clone)"), 0.0f);
        }
    }



    void Update()
    {



        //Debug.Log(action);
        //Debug.Log(Feel.inContact);
        //GameObject.Find("map_ui").transform.localPosition = new Vector2(-transform.position.x, -transform.position.z);
        //GameObject.Find("map_cam").transform.localEulerAngles = new Vector3(90.0f, c3.transform.localEulerAngles.y, 0.0f);

        //Debug.Log(pauza);

        curent_cut = Time.deltaTime;
        //Debug.Log(curent_cut);

        if(Trg.inContact == 0)
        {
            vy = GetComponent<Rigidbody>().velocity.y;
        }
        if (Trg.inContact == 1)
        {
            if(vy <= -22.0f)
            {
                pauza = 1;
            }
        }

        //Debug.Log(parametrii_ego.my_var_3);

        if(muscat > 0)
        {
            parametrii_ego.my_var_3 = parametrii_ego.my_var_3 - 1;
            if (parametrii_ego.my_var_3 <= 0)
            {
                parametrii_ego.my_var_3 = 0;

               // if (pauza == 0)
               // {
                    pauza = 1;
               // }

            }
        }
        /*
         if (transform.position.y >= 4.0f)
         {
             eotX = 70.0F;
         }
         if (transform.position.y < 3.0f)
         {
             eotX = 90.0F;
         }

        // rotX -= (rotX - eotX) * 0.1F;
         c2.transform.localEulerAngles = new Vector3(eotX, 0.0f, 0.0f);
         */
        if (pauza == 12)
        {
            //rotations();
            coord_imputs();
            if (stop_force == 0)
            {
                fata = 0;
                lateral = 0;
                lateral_s = 0;
                lateral_d = 0;

                dirE.x = 0;
                dirE.y = 0;
                dirE.z = 0;
                stop_force = 1;
            }

            ego_idle();
            action = "ego_idle";
        }

        if (pauza == 0)
        {
            stop_force = 0;
            rotations();
            coord_imputs();
            
            ego_idle();
            ego_run();
            ego_push();
            ego_drag();
            ego_right();
            ego_left();
            ego_back();
            ego_hit();

            ego_change_weapon();
            ego_jump_from_stand();
            ego_jump_from_move();
            ego_fall_stand();
            ego_fall_move();
            ego_land();

            ego_climb_edge_over_low();
            ego_climb_edge_over_high();
            ego_over_to_stabile();

            ego_climb_rope();
            ego_climb_leader();
        }

        if (pauza == 1)
        {
            ego_die();
            butt_foreward.apasat = 0;
            butt_left.apasat = 0;
            butt_right.apasat = 0;
            butt_bw.apasat = 0;

            fata = 0;
            lateral = 0;
            lateral_s = 0;
            lateral_d = 0;

            dirE.x = 0;
            dirE.y = 0;
            dirE.z = 0;
            action = "ego_die";
            if (die_once == 0)
            {
                die_and_reload();
                die_once = 1;
            }
        }

        if (pauza == 11)
        {
            ego_die();

            butt_foreward.apasat = 0;
            butt_left.apasat = 0;
            butt_right.apasat = 0;
            butt_bw.apasat = 0;

            fata = 0;
            lateral = 0;
            lateral_s = 0;
            lateral_d = 0;

            dirE.x = 0;
            dirE.y = 0;
            dirE.z = 0;
            action = "ego_die";
            if (die_once == 0)
            {
                die_and_reload_2();
                die_once = 1;
            }
        }

        if (pauza == 2)
        {
            butt_foreward.apasat = 0;
            butt_left.apasat = 0;
            butt_right.apasat = 0;
            butt_bw.apasat = 0;

            fata = 0;
            lateral = 0;
            lateral_s = 0;
            lateral_d = 0;

            dirE.x = 0;
            dirE.y = 0;
            dirE.z = 0;
            ego_idle();
            action = "ego_idle";
        }
    }
}



