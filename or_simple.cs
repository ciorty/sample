using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class or_simple : MonoBehaviour {
	float eotY;
	float rotX;
	float speedX;
    float spdX;
    float sdZ;
	float trage;
	float pdaX;
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

    public string action;

    float check_over_high;
    int start_jump;
    public static GameObject rope_to_climb;
    public static string game_mode;

    public int stm;
    public int obstacol;
    float rate_rot;

    public static int mode_change;
    public static int mode_hit;

    string ultimul;

    public int arma;
    public int gloante_0;
    public int gloante_1;
    public int gloante_2;

    GameObject prefabBullet;
    GameObject to_shoot;
    public int once_drag;
    public GameObject gamo;
    public GameObject tamo;

    HingeJoint tempHinge;
    GameObject tam;

    public static GameObject weapon_fight;
    public static GameObject weapon_melee;
    public static GameObject suport_fight_hand;
    public static GameObject suport_melee_hand;
    public static GameObject suport_fight_back;
    public static GameObject suport_melee_back;
    int roteste;
    int one_touch;

    float angle_ini;


    Vector3 dirLookEgo;
    Vector3 dirMers;

    Vector3 vertical;

    float angle_start;
    float angle_move;
    

    //_____________________________________

    void Awake()
    {
        Application.targetFrameRate = 100;
    }

    void Start () {
        arma = 0;
        gloante_1 = 100;
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
        rotX = rotX_init;
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
        rate_rot = 0.5f;
    }

    void coord_imputs()
    {
        if (butt_left.apasat ==1) { lateral = 1; }
        if (butt_right.apasat == 1) { lateral = -1; }
        if (butt_left.apasat == 0 && butt_right.apasat == 0)
        {
            lateral = 0;
        }
    }

    
    void rotations()
    {
        if (Application.isEditor)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(trage == 0)
                {
                    k = pdaX - Input.mousePosition.x;
                    m = pdaY - Input.mousePosition.y;
                    trage = 1;
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
                        trage = 1;
                    }
                }
            }
        }







        if (Application.isEditor)
        {
            if (Input.GetMouseButtonUp(0))
            {

                one_touch = 0;
                manager_hud_minimal.move_circles.transform.rotation = Quaternion.Euler(0, 0, 45);
                manager_hud_minimal.test_mouse.transform.position = new Vector3(0, 0, 0);
                fata = 0;
                trage = 0;
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

                        one_touch = 0;
                        manager_hud_minimal.move_circles.transform.rotation = Quaternion.Euler(0, 0, 45);
                        manager_hud_minimal.test_mouse.transform.position = new Vector3(0, 0, 0);
                        //fata = 0;
                        trage = 0;
                    }
                }
            }
        }







        if (trage == 1)
        {
            if (Application.isEditor)
            {
                pdaX = Input.mousePosition.x + k;
                manager_hud_minimal.test_mouse.transform.position = Input.mousePosition;
            }

            if (Application.isMobilePlatform)
            {
                for (var i = 0; i < Input.touchCount; ++i)
                {
                    if (Input.GetTouch(i).position.x > Screen.width / 2)
                    {
                        pdaX = Input.GetTouch(i).position.x + k;
                        manager_hud_minimal.test_mouse.transform.position = new Vector2(Input.GetTouch(i).position.x, Input.GetTouch(i).position.y);
                    }
                }
            }

           
            if (one_touch == 0)
            {
                angle_start = Vector3.Angle( manager_hud_minimal.test_mouse.transform.position - manager_hud_minimal.move_circles.transform.position, new Vector3(0, 1, 0));
                one_touch = 1;
            }

            if (manager_hud_minimal.test_mouse.transform.position.x - manager_hud_minimal.move_circles.transform.position.x <= 0)
            {
                angle_move = Vector3.Angle(manager_hud_minimal.test_mouse.transform.position - manager_hud_minimal.move_circles.transform.position, new Vector3(0, 1, 0));
                manager_hud_minimal.move_circles.transform.rotation = Quaternion.Euler(0, 0, angle_move - angle_start + 45.0f);
            }

            if (manager_hud_minimal.test_mouse.transform.position.x - manager_hud_minimal.move_circles.transform.position.x > 0)
            {
                angle_move = Vector3.Angle(-manager_hud_minimal.test_mouse.transform.position + manager_hud_minimal.move_circles.transform.position, new Vector3(0, 1, 0));
                manager_hud_minimal.move_circles.transform.rotation = Quaternion.Euler(0, 0, angle_move - angle_start + 45.0f + 180.0f);
            }

            manager_hud_minimal.center_dist = Vector2.Distance(manager_hud_minimal.move_circles.transform.localPosition, manager_hud_minimal.test_mouse.transform.localPosition);

            if (manager_hud_minimal.center_dist > 450.0f ) { fata = 1; }
            if (manager_hud_minimal.center_dist <= 450.0f && manager_hud_minimal.center_dist > 420.0f) { fata = 0; }
            if (manager_hud_minimal.center_dist <= 420.0f ) { fata = -1; }
        }

        eotY -= (eotY - pdaX *0.6f) *0.4f;
        c3.transform.localEulerAngles = new Vector3(0.0f, eotY, 0.0f);


        dirE.x = weapon_mode * fata *obstacol*c3.transform.forward.x - 150 * lateral * c3.transform.right.x;
        dirE.y = 0;
        dirE.z = weapon_mode * fata *obstacol*c3.transform.forward.z - 150 * lateral * c3.transform.right.z;
    }
 
    void Update()
    {
        rotations();
        coord_imputs();
    }
}
