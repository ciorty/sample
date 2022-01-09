using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class zbb_civil : MonoBehaviour
{
    public RaycastHit hitCheck;
    public RaycastHit hideCheck;
    public RaycastHit hitShoot1;
    public RaycastHit hitShoot2;
    public Transform target;
    UnityEngine.AI.NavMeshAgent agent;
    public Vector3 dirLookEgo;
    public Vector3 dirMers;
    public Vector3 dirReg;
    public int see_ego_clone;
    public int get_ego;
    public int get_ego_clone;
    public float kx;
    public float ky;
    public float kz;
    public int once;
    public Vector3 vdist;
    public float distance;
    public float reg_distance;
    public Vector3 lDirection;
    public int angle;
    public int angle_random;
    public int angle_opus;
    private int setAction;
    public int angleAdd;
    public int onceAvoid;
    public int aproape;
    public float alfa2;
    public Vector3 frecare;
    public int reg_index;
    public int reg_index_2;
    public int reg_index_clone;
    public int onceReg;
    public string movement;
    public int check_view_now;
    public int chose_action;
    public bool hide;
    public float distRegEgo;
    public float distRegEnn;
    public float alfaTake;
    public int onceK;
    public static int startMove;
    public RaycastHit hitShoot;
    public int sh;
    public int gunshoot;
    public float shootForce;
    //public sunete_2 mg_sound;
    private int far;
    public AudioClip shoot_01;
    //private Animator animator;
    public Component[] bones;
    public int inert;
    public GameObject prefabEnn;
    public GameObject prefabBullet;
    public GameObject prefabSound;
    //public sunete_enn_shoot snt;
    public GameObject to_shoot;
    public List<int> index_array;
    public List<int> index_array_2;
    public RaycastHit recDown;
    public RaycastHit recFw;
    int contact_visual;
    public env snts;
    public int check_podium;
    public int check_inert;

    public int vazut;

    public Transform hit_direction;
    public int largimea;
    public GameObject to_hit;

    public List<GameObject> fadeObject;
    public int startFade;

    public GameObject death;
    private ParticleSystem prefab_smoke;

    int once_smoke;
    float diff;

    public float minVisible;
    public float maxVisible;
    GameObject egos;
    float distanceVisible;
    int onceV;
    //ObjectiveIndicator coms;
    //
    public GameObject new_species;
    Transform p1;
    //GameObject mesh_agent;

    public int particular;
    public int numarat;

    public int bomba_pulii;

    List<float> resp;
    int to_rep;

    public int cadenta;
    GameObject prefabMuzzle;

    GameObject take_points;
    public int activ;

    public int vede_peste_tot;

    public GameObject mesh_agent;
    public animations_zbb_0 movings;

    public static int atack;
    int get_info;

    Transform rightHandObj;
    Transform lookAtObj;
    int once_start;
    int no_clones_time;

    public GameObject ego_shadow;
    int dw;
    public float rdius;
    //public Texture myTexture_1;
    //public Texture myTexture_2;
    //public Texture myTexture_3;
    //public Texture myTexture_4;
    //public Texture myTexture_5;
    //public Texture myTexture_6;
    public GameObject mesha;
    //Renderer rend;

    //public Component[] texturile;
    public Texture[] tx_list;// = new Texture[7];
    List<Texture> texturile;
    int tex_random;
    public Texture myT;



    void Start()
    {
        tex_random = Random.Range(0, 6);

        texturile = new List<Texture>();
        //var tx_list = new Texture[];
        /*
        texturile.Add(myTexture_1);
        texturile.Add(myTexture_2);
        texturile.Add(myTexture_3);
        texturile.Add(myTexture_4);
        texturile.Add(myTexture_5);
        texturile.Add(myTexture_6);
        */
        //texturile[0] = myTexture;
        //GameObject go = GameObject.CreatePrimitive(PrimitiveType.Plane);
        myT = tx_list[tex_random];
        mesha.GetComponent<Renderer>().material.mainTexture = myT;

        rdius = 0.7f;
        //mesh_agent = GameObject.Find("enn_mesh");
        egos = GameObject.Find("sense_ego");
       // animator = transform.Find("Cont_Actor").transform.Find("actor_1_pose").GetComponent<Animator>();
        //diff = (Random.Range(10, 100))*0.01f;
        
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        agent.enabled = false;    
        setAction = 0;
        movement = "inert_agent_enabled_false";
        /*
        bones = gameObject.GetComponentsInChildren<Rigidbody>();
        GetComponent<Rigidbody>().isKinematic = false;
        foreach (Rigidbody ragdoll in bones)
        {
            ragdoll.isKinematic = true;
        }
        */
        prefabBullet = (GameObject)Resources.Load("bullet_enn", typeof(GameObject));
        prefabSound = (GameObject)Resources.Load("enn_shoot_1_sound", typeof(GameObject));
        //prefabHit = (GameObject)Resources.Load("enn_shoot_1_sound", typeof(GameObject));
        //to_shoot = GameObject.Find("enn_mesh").transform.Find("enn_shoot_dummie").gameObject;
        prefab_smoke = death.GetComponent<ParticleSystem>();
        prefabMuzzle = (GameObject)Resources.Load("solo_gun", typeof(GameObject));
        take_points = (GameObject)Resources.Load("Smoke_points_enn_0", typeof(GameObject));

        if (gameObject.name == "enn_civil" || gameObject.name == "enn_civil(Clone)")//MARE GRIJA LA REDENUMIREA CHARS DIN JOC (EX: ENN_CIVIL (1) ....ETC)
        {
            new_species = (GameObject)Resources.Load("enn_civil", typeof(GameObject));
            cadenta = 20;
        }

        if (gameObject.name == "enn_soldier" || gameObject.name == "enn_soldier(Clone)")
        {
            new_species = (GameObject)Resources.Load("enn_soldier", typeof(GameObject));
            cadenta = 10;
        }

        far = cadenta;
        resp = new List<float>();
        atack = 2;
        movings = mesh_agent.GetComponent<animations_zbb_0>();

        contact_visual = 0;


        //avatar = GetComponent<Animator>();
        //rightHandObj = GameObject.Find("targ").transform;
        //lookAtObj = GameObject.Find("targ").transform;

        //Invoke("fff", 0.5f);
    }


    void fff()
    {
        inert = 1;
    }

    void stai()
    {
        if (movings.once != "neutru_idle") { movings.once = "idle"; }
    }

    void alergi()
    {
       if(movings.once != "neutru_run") { movings.once = "run"; }
    }

    void tragi()
    {
        if (movings.once != "neutru_aim") { movings.once = "aim"; }
    }

    void mergi()
    {
        if (movings.once != "neutru_walk") { movings.once = "walk"; }
    }

    void inapoi()
    {
        if (movings.once != "neutru_back") { movings.once = "back"; }
    }

    void alert()
    {
        if (movings.once != "neutru_alert") { movings.once = "alert"; }
    }

    //___________________________________________________________________________________

    public void inert_agent_enabled_false()//miscarea initiala, fara miscare, din care trece in patrol
    {
        if (movement == "inert_agent_enabled_false")
        {
            stai();
            agent.enabled = true;
            agent.speed = 0.0f;
            agent.radius = rdius;

            if (once_start == 0)
            {

                //no_clones_time = 100* snts.enns_number; //snts.enns_number

                no_clones_time = 4 * (snts.enns_number+1);
                once_start = 1;
            }
            setAction = setAction + 1;
            if (setAction >= no_clones_time)
            {     
                movement = "lookfor_patrol_point";
                setAction = 0;                           
            }
        }
    }

    //___________________________________________________________________________________

    public void interm_target_in_afara_vederii()
    {
        if (movement == "interm_target_in_afara_vederii")
        {
            setAction = 0;
            movement = "lookfor_ego_hide";
        }
    }

    public void interm_target_la_vedere()
    {
        if (movement == "interm_target_la_vedere")
        {
            agent.speed = 0.0f;
            setAction = 0;
            movement = "lookfor_ego_view";
        }
    }

    //___________________________________________________________________________________

    public void lookfor_patrol_point(int timing)
    {
        if (movement == "lookfor_patrol_point")
        {
            agent.enabled = true;
            agent.speed = 0.0f;
            agent.radius = rdius;
            roteste_corpul_spre_inainte();

            if (setAction == 0)
            {
                take_patrol();
                setAction = 1;
            }
        }
    }

    public void lookfor_ego_view(int timing)
    {
        if (movement == "lookfor_ego_view")
        {
            agent.speed = 0.0f;
            roteste_corpul_spre_ego();

            if (setAction == 0)
            {
                create_index_array_2();
                take_view();
                setAction = 1;
            }
        }
    }

    public void lookfor_ego_hide(int timing)
    {
        if (movement == "lookfor_ego_hide")
        {
            agent.speed = 0.0f;
            roteste_corpul_spre_ego();

            if (setAction == 0)
            {
                create_index_array();
                take_hide();
                setAction = 1;
            }
        }
    }

    //___________________________________________________________________________________

    public void create_index_array()
    {
        index_array.Clear();
        for (int i = 0; i < largimea; i++)
        {
            index_array.Add(i);
        }
    }

    public void create_index_array_2()
    {
        index_array_2.Clear();
        for (int i = 0; i < largimea; i++)
        {
            index_array_2.Add(i);
        }
    }

    //___________________________________________________________________________________

    public void action_patrol(int timing)
    {
        if (movement == "action_patrol")
        {
            stai();
            agent.speed = 0.0f;
            setAction = setAction + 1;
            if (setAction >= timing)
            {
                movement = "lookfor_patrol_point";
                setAction = 0;
            }
        }
    }

    public void action_choose(int timing)//timp de "timing" secunde, sta orientat spre ego, si alege ce sa faca
    {
        if (movement == "action_choose")
        {
            alert();
            agent.speed = 0.0f;
            roteste_corpul_spre_ego();

            setAction = setAction + 1;
            if (setAction >= 60)
            {
                chose_action = Random.Range(0, 5);
                if (snts.proxi == 1)
                {
                    if (chose_action == 0) { movement = "lookfor_ego_hide"; }
                    if (chose_action == 1) { movement = "lookfor_ego_hide"; }
                    if (chose_action == 2) { movement = "lookfor_ego_view"; }
                    if (chose_action == 3) { movement = "lookfor_ego_hide"; }
                    if (chose_action == 4) { movement = "lookfor_ego_hide"; }
                }

                if (snts.proxi == 0)
                {
                    if (chose_action == 0) { movement = "lookfor_ego_hide"; }
                    if (chose_action == 1) { movement = "lookfor_ego_hide"; }
                    if (chose_action == 2) { movement = "lookfor_ego_view"; }
                    if (chose_action == 3) { movement = "lookfor_ego_hide"; }
                    if (chose_action == 4) { movement = "lookfor_ego_hide"; }
                }

                setAction = 0;
            }
        }
    }

    //___________________________________________________________________________________


    public void deplasare_spre_ego()//movement == "deplasare_spre_ego";
    {
        if (movement == "deplasare_spre_ego")
        {
           // mergi();
            alergi();
            
            //target = ego_shadow.transform;// GameObject.Find("ego").transform;

            //agent.SetDestination(target.position);
            roteste_corpul_spre_inainte();

            agent.SetDestination(target.position);
            agent.speed = 4.5f + 8*diff;
            movings.animator.speed = 1.2f;// + diff;
            agent.radius = rdius;


            reg_distance = Vector3.Distance(transform.position, target.position);
            //Debug.Log(agent.speed);
            
            if (snts.proxi == 1)
            {
                //dw = 0;

                //ego_shadow = GameObject.Find("sense_ego").transform;
                ego_shadow = GameObject.Find("ego");
                target = ego_shadow.transform;
                if (reg_distance <= 2.1f)
                {
                    //tragi();

                    movement = "loveste";
                }
            }

            if (snts.proxi == 0)
            {
                //reg_distance = Vector3.Distance(transform.position, target.transform.position);
               //if (dw == 0)
              // {
                    //Debug.Log("hhh");
                    //GameObject.Find("test_respawn").transform.position = GameObject.Find("ego").transform.position;
                    ego_shadow = GameObject.Find("test_respawn");
                    target = ego_shadow.transform;
                //ego_shadow = GameObject.Find("test_respawn").transform;
                //target = GameObject.Find("test_respawn").transform;
                // dw = 1;
                // }

                //target = ego_shadow.transform;


                /*
                setAction = setAction + 1;

               
                if (setAction <= no_clones_time*0.5f)
                {

                }

                if (setAction > no_clones_time * 0.5f)
                {
                    setAction = 0;
                    movement = "pacalit";
                }
                */

                if (reg_distance >3.0f)
                {
                    setAction = setAction + 1;
                    if (setAction <= 3 * no_clones_time)
                    {

                    }

                    if (setAction >3 * no_clones_time)
                    {
                        setAction = 0;
                        movement = "pacalit";
                    }
                }

                if (reg_distance <= 3.0f)
                {
                    setAction = 0;
                    movement = "pacalit";
                }






                // if (reg_distance <= 3.0f)
                // {

                // }
            }

            
        }
    }


    public void loveste()
    {

        if (movement == "loveste")
        {
            roteste_corpul_spre_ego();
            setAction = 0;
            tragi();
            if(orientare_0.fata == 0)
            {
                agent.speed = 0.0f;
            }
            //agent.speed = 0.0f;//NU STIU CE SA ZIC LA ASTA......
            agent.radius = rdius;

            reg_distance = Vector3.Distance(transform.position, target.position);
            //Debug.Log(agent.speed);

            if (snts.proxi == 1)
            {
                //dw = 0;

                //ego_shadow = GameObject.Find("sense_ego").transform;
                //target = ego_shadow;
                if (reg_distance >= 2.2f )
                {
                    //tragi();
                    setAction = 0;
                    movement = "deplasare_spre_ego";
                }
            }

            if (snts.proxi == 0)
            {
                //reg_distance = Vector3.Distance(transform.position, target.transform.position);
                // if (dw == 0)
                // {
                //    GameObject.Find("test_respawn").transform.position = GameObject.Find("sense_ego").transform.position;
                //   dw = 1;
                //}
                //ego_shadow = GameObject.Find("test_respawn").transform;
                // target = ego_shadow;

                // if (reg_distance <= 5.0f)
                //{

                setAction = 0;
                movement = "pacalit";
                //}
            }


        }


    }


    public void heading_patrol_point(int timing)//enn alege si se indreapta catre un punct random de patrulare
    {
        if (movement == "heading_patrol_point")
        {
            agent.enabled = true;
            roteste_corpul_spre_inainte();

            /*
            if (snts.vazut == 1)//daca a fost vazut de un coleg
            {
                stai();
                agent.speed = 0.0f;
                setAction = 0;
                movement = "surprins";
                activ = 1;
            }
            */
            // if (vede_peste_tot == 0)//reactioneaza doar cand ego-ul este in nav_scene-ul enn-ului
            // {
            if (aproape == 1 && Vector3.Angle(dirLookEgo, dirMers) <= 80.0f && snts.proxi == 1)
                {
                    stai();
                    agent.speed = 0.0f;
                    setAction = 0;
                    movement = "surprins";
                    snts.vazut = 1;
                }

                if (aproape == 0 || Vector3.Angle(dirLookEgo, dirMers) > 80.0f || snts.proxi == 0)
                {
                    mergi();
                    //agent.speed = 1.0f;
                    agent.speed = 1.0f + diff;
                    movings.animator.speed = 0.8f + diff;
            }
           // }
            /*
            if (vede_peste_tot == 1)//reactioneaza si cand ego-ul este in afara nav_scene-ului
            {
                if (aproape == 1 && Vector3.Angle(dirLookEgo, dirMers) <= 80.0f)
                {
                    stai();
                    agent.speed = 0.0f;
                    setAction = 0;
                    movement = "surprins";
                    snts.vazut = 1;
                }

                if (aproape == 0 || Vector3.Angle(dirLookEgo, dirMers) > 80.0f)
                {
                    mergi();
                    agent.speed = 1.0f;
                }
            }
            */
            reg_distance = Vector3.Distance(transform.position, target.transform.position);
            if (reg_distance <= 1.0f)
            {
                setAction = 0;
                movement = "action_patrol";
            }
        }
    }

    public void heading_ego_view(int timing)//enn alege si se indreapta catre un puncte de unde se vede ego-ul si poate trage in el
    {
        if (movement == "heading_ego_view")
        {
            agent.enabled = true;
            if (contact_visual == 1 && Vector3.Angle(dirLookEgo, dirMers) > 80.0f)
            {
                setAction = setAction + 1;

                if (setAction >= 0 && setAction < 120)
                {
                    agent.speed = 2.0f;
                    inapoi();
                    roteste_corpul_spre_ego();
                }

                if (setAction >= 120)
                {
                    agent.speed = 1.0f;
                    alergi();
                    roteste_corpul_spre_inainte();
                }
            }

            if (contact_visual == 1 && Vector3.Angle(dirLookEgo, dirMers) <= 80.0f)
            {
                setAction = 0;
                movement = "surprins";
            }

            if (contact_visual == 0)
            {
                agent.speed = 1.0f;
                alergi();
                roteste_corpul_spre_inainte();
            }

            reg_distance = Vector3.Distance(transform.position, target.transform.position);
            if (reg_distance <= 1.0f)
            {
                setAction = 0;
                movement = "action_choose";
            }

            reg_distance = Vector3.Distance(transform.position, target.transform.position);
            if (reg_distance <= 1.0f)//daca intre timp ego-ul s-a miscat, enn tot ajunge la target si intra in action_choose
            {
                setAction = 0;
                movement = "action_choose";
            }
        }
    }

    public void heading_ego_hide(int timing)//enn alege si se indreapta catre un punct unde nu este vazut de ego, si nu se poate trage catre el
    {
        if (movement == "heading_ego_hide")
        {
            agent.enabled = true;
            if (contact_visual == 1 && Vector3.Angle(dirLookEgo, dirMers) > 80.0f)
            {
                setAction = setAction + 1;

                if (setAction >= 0 && setAction < 120)
                {
                    agent.speed = 2.0f;
                    inapoi();
                    roteste_corpul_spre_ego();
                }

                if (setAction >= 120)
                {
                    agent.speed = 1.0f;
                    alergi();
                    roteste_corpul_spre_inainte();
                }
            }

            if (contact_visual == 0)
            {
                agent.speed = 1.0f;
                alergi();
                roteste_corpul_spre_inainte();
            }

            if (contact_visual == 1 && Vector3.Angle(dirLookEgo, dirMers) <= 80.0f)
            {
                setAction = 0;
                movement = "surprins";
            }

            reg_distance = Vector3.Distance(transform.position, target.transform.position);
            if (reg_distance <= 1.0f)
            {
                setAction = 0;
                movement = "action_choose";
            }
        }
    }

    public void pacalit()
    {
        if (movement == "pacalit")
        {

            alert();
            movings.animator.speed = 5*diff;
            agent.speed = 0.0f;
            agent.radius = rdius;
            roteste_corpul_spre_ego();
            setAction = setAction + 1;

            /*
            if (setAction <= no_clones_time)
            {

            }
            if (setAction > no_clones_time)
            {
                setAction = 0;
                movement = "deplasare_spre_ego";
            }
            */

            if(snts.proxi == 0)
            {
                if (setAction > 10*no_clones_time)
                {
                    setAction = 0;
                    movement = "lookfor_patrol_point";
                }
            }

            if (snts.proxi == 1 && aproape == 0)
            {
                if (setAction > 2 * no_clones_time)
                {
                    setAction = 0;
                    movement = "pacalit";
                }
            }
            if (snts.proxi == 1 && aproape == 1)
            {
                if (setAction > 2 * no_clones_time)
                {
                    setAction = 0;
                    movement = "surprins";
                }
            }
        }
    }

    public void surprins()
    {
        if (movement == "surprins")
        {

            alert();
            agent.speed = 0.0f;
            agent.radius = rdius;
            roteste_corpul_spre_ego();
            setAction = setAction + 1;
            //if (setAction <= 180)
            //{

           // }
            if (setAction > no_clones_time)
            {
                setAction = 0;
                movement = "deplasare_spre_ego";
            }
        }
    }

    
    public void heading_ego_hide_test()
    {
        if (movement == "heading_ego_hide_test")
        {
            agent.enabled = true;
            if (aproape == 0 || Vector3.Angle(dirLookEgo, dirMers) > 70.0f)
            {
                setAction = 0;
                movement = "heading_ego_hide";
            }

            if (aproape == 1 && Vector3.Angle(dirLookEgo, dirMers) <= 70.0f)
            {
                setAction = 0;
                movement  = "lookfor_ego_hide";
            }
        }
    }
   

    //___________________________________________________________________________________   

    public void take_patrol()//search "patrol_point"
    {
        reg_index = Random.Range(0, snts.move_array.Count);
        target = snts.move_array[reg_index].transform;
        if (agent.isOnNavMesh == true)
        {
            agent.SetDestination(target.position);
            agent.speed = 0.0f;
        }
        roteste_corpul_spre_inainte();
        setAction = 0;
        movement = "heading_patrol_point";
    }

    public void take_view()// search "view_point"
    {
        reg_index_2 = Random.Range(0, index_array_2.Count);
        index_array_2.RemoveAt(reg_index_2);
        bool hidek = Physics.Linecast(GameObject.Find("sense_ego").transform.position, snts.move_array[reg_index_2].transform.position);
        float distance_hide = Vector3.Distance(transform.position, snts.move_array[reg_index_2].transform.position);
        agent.speed = 0.0f;

        if (hidek == true)//daca EXISTA un obiect intre ego si enn
        {
            if (index_array_2.Count > 0)
            {
                take_view();
            }
            if (index_array_2.Count == 0)
            {
                movement = "interm_target_in_afara_vederii";
            }
        }

        if (hidek == false)//daca NU EXISTA un obiect intre ego si enn
        {
            target = snts.move_array[reg_index_2].transform;
            agent.speed = 0.0f;
            agent.SetDestination(target.transform.position);
            roteste_corpul_spre_ego();
            setAction = 0;
            create_index_array_2();
            movement = "heading_ego_view";
        }
    }

    public void take_hide()// search "hide_point"
    {
        reg_index = Random.Range(0, index_array.Count);
        index_array.RemoveAt(reg_index);
        bool hidek = Physics.Linecast(GameObject.Find("sense_ego").transform.position, snts.move_array[reg_index].transform.position);
        float distance_hide = Vector3.Distance(transform.position, snts.move_array[reg_index].transform.position);
        agent.speed = 0.0f;

        if (hidek == false)//nu se poate ascunde
        {
            if (index_array.Count > 0)
            {
                take_hide();
            }
            if (index_array.Count == 0)
            {
                movement = "interm_target_la_vedere";
            }
        }

        if (hidek == true)//se poate ascunde
        {
            target = snts.move_array[reg_index].transform;
            agent.speed = 0.0f;
            agent.SetDestination(target.transform.position);
            roteste_corpul_spre_ego();
            setAction = 0;
            create_index_array();
            movement = "heading_ego_hide";
        }
    }

    //___________________________________________________________________________________

    public void trage_la_vedere()
    {
        if (Physics.Raycast(mesh_agent.transform.position, mesh_agent.transform.forward, out hitShoot, 2000))
        {
            if (hitShoot.collider)
            {
                if (vede_peste_tot == 0)
                {
                    if (hitShoot.collider.name == "sense_ego" && snts.proxi == 1)
                    {
                        far = far - 1;
                        if (far <= 0)
                        {
                            gloanteGenerator();
                            far = cadenta;
                        }
                    }
                }

                if (vede_peste_tot == 1)
                {
                    if (hitShoot.collider.name == "sense_ego")
                    {
                        far = far - 1;
                        if (far <= 0)
                        {
                            gloanteGenerator();
                            far = cadenta;
                        }
                    }
                }
                /*
                if (hitShoot.collider.name != "sense_ego")
                {
                    if (once == 1)
                    {
                        gunshoot = 0;
                        //snt.shoot_action = 0;
                        once = 0;
                    }
                }
                */
            }
        }

        if (gunshoot == 1)
        {

        }
    }

    public void gloanteGenerator()
    {
        GameObject instanceMuzzle;
        instanceMuzzle = Instantiate(prefabMuzzle, to_shoot.transform.position, mesh_agent.transform.rotation) as GameObject;
        Destroy(instanceMuzzle, 0.05f);

        //snt.aud_shoot_reload();
        GameObject instanceSound;
        instanceSound = Instantiate(prefabSound, transform.position, Quaternion.identity) as GameObject;
        instanceSound.transform.parent = transform;

        GameObject instanceBullet;
        instanceBullet = Instantiate(prefabBullet, to_shoot.transform.position, mesh_agent.transform.rotation) as GameObject;
        shootForce = 16000;
        instanceBullet.GetComponent<Rigidbody>().mass = 2;
        instanceBullet.GetComponent<Rigidbody>().AddForce(mesh_agent.transform.forward * shootForce);

        Destroy(instanceSound, 1.0f);
        Destroy(instanceBullet, 2.5f);
    }

    //___________________________________________________________________________________

    public void roteste_corpul_spre_ego()
    {
       // agent.speed = 0.0f;
        //agent.acceleration = 0.0f;
        //agent.angularSpeed = 0.0f;
        //transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(dirLookEgo), transform.rotation, 0.8f);//cu cat e mai mare. cu atat mai incet
       // transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
       //mesh_agent.transform.rotation = Quaternion.Lerp( mesh_agent.transform.rotation, Quaternion.LookRotation(dirLookEgo), 0.3f);
       if(mesh_agent)
      mesh_agent.transform.rotation = Quaternion.RotateTowards(mesh_agent.transform.rotation, Quaternion.LookRotation(dirLookEgo), 5.0f);//cu cat mai mare -> mai rapid


        //Vector3 targetDir = target.position - transform.position;
        //float step = speed * Time.deltaTime;
        //Vector3 newDir = Vector3.RotateTowards(mesh_agent.transform.forward, egos.transform.position - mesh_agent.transform.position, 0.6f, 0.6f);
        //Debug.DrawRay(transform.position, newDir, Color.red);
        //mesh_agent.transform.rotation = Quaternion.LookRotation(newDir);
        mesh_agent.transform.localEulerAngles = new Vector3(0, mesh_agent.transform.localEulerAngles.y, 0);
    }

    public void roteste_corpul_spre_inainte()
    {
        //agent.acceleration = 500f;
        // agent.angularSpeed = 300.0f;
        //mesh_agent.transform.rotation = Quaternion.Lerp(Quaternion.LookRotation(transform.forward), mesh_agent.transform.rotation, 0.8f);
        //mesh_agent.transform.eulerAngles = Vector3.Lerp(mesh_agent.transform.eulerAngles, transform.forward, 0.5f);
        //mesh_agent.transform.rotation = Quaternion.Lerp(mesh_agent.transform.rotation, Quaternion.LookRotation(transform.forward), 0.3f);
        if(mesh_agent)
       mesh_agent.transform.rotation = Quaternion.RotateTowards(mesh_agent.transform.rotation, Quaternion.LookRotation(transform.forward), 5.0f);//cu cat mai mare -> mai rapid

        //Vector3 newDir = Vector3.RotateTowards(mesh_agent.transform.forward, transform.forward, 0.6f, 0.6f);
        //Debug.DrawRay(transform.position, newDir, Color.red);
        //mesh_agent.transform.rotation = Quaternion.LookRotation(newDir);
        if (mesh_agent)
            mesh_agent.transform.localEulerAngles = new Vector3(0, mesh_agent.transform.localEulerAngles.y, 0);
    }

    public void roteste_corpul_spre_spate()
    {
        //agent.acceleration = 500f;
        // agent.angularSpeed = 300.0f;
        //mesh_agent.transform.rotation = Quaternion.Slerp(Quaternion.LookRotation(-transform.forward), mesh_agent.transform.rotation, 0.8f);
        //mesh_agent.transform.rotation = Quaternion.Lerp( mesh_agent.transform.rotation, Quaternion.LookRotation(-transform.forward), 0.3f);
        //mesh_agent.transform.rotation = Quaternion.RotateTowards(mesh_agent.transform.rotation, Quaternion.LookRotation(-transform.forward), 10.0f);//cu cat mai mare -> mai rapid

        Vector3 newDir = Vector3.RotateTowards(mesh_agent.transform.forward, -transform.forward, 0.3f, 0.0F);
        //Debug.DrawRay(transform.position, newDir, Color.red);
        if (mesh_agent)
            mesh_agent.transform.rotation = Quaternion.LookRotation(newDir);
        mesh_agent.transform.localEulerAngles = new Vector3(0, mesh_agent.transform.localEulerAngles.y, 0);
    }

    //___________________________________________________________________________________

    void fumega()
    {
        //ParticleSystem st4;
        //st4 = Instantiate(death, transform.position, Quaternion.identity) as ParticleSystem;
        //Destroy(st4, 3.0f);
    }

    void genereaza()
    {
        for (int i = 0; i < snts.respawn_array.Count; i++)
        {
            Vector3 vect_respw = egos.transform.position - snts.respawn_array[i].transform.position;
            float dist_respw = vect_respw.magnitude;
            resp.Add(dist_respw);
        }

        float max_resp = Mathf.Max(resp.ToArray());
        for (int j = 0; j < snts.respawn_array.Count; j++)
        {
            if(resp[j] == max_resp)
            {
                to_rep = j;
            }
        }

        Transform target_resp;
        target_resp = snts.respawn_array[to_rep].transform;

        GameObject instance_species;
        instance_species = Instantiate(new_species, target_resp.position, Quaternion.identity) as GameObject;
    }

    void infos()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {

            if (get_info == 0)
            {
                //Debug.Log(contact_visual);
                get_info = 1;
            }
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            get_info = 0;
        }
    }


    /*
    void OnAnimatorIK()
    {
       //vatar.SetLookAtWeight(1.0f, 0.3f, 0.6f, 1.0f, 0.5f);
        movings.animator.SetLookAtPosition(lookAtObj.position);
    }
    */

    //___________________________________________________________________________________

    void Update()
    {
        if (inert == 1)//LA MOARTEA ENN-ULUI
        {
            agent.enabled = false;
            if (check_inert == 0)
            {
                check_inert = 1;
            }

            if (once_smoke == 0)
            {
                if (snts.vazut == 1 && snts.has_elevator == 1 && snts.kills_number < 5)
                {

                }
                once_smoke = 1;
            }

            //transform.position = new Vector3(transform.position.x, transform.position.y - 10.2f, transform.position.z);
        }

        if (inert == 0)//CAT TIMP ESTE ENN-UL VIU
        {
            //TREBUIE INCLUSA DECIZIA DE RE-KINEMATIZARE, PENTRU SITUATIA CAND ACELASI ENN RESPAWN IN SCENA
            Destroy(GetComponent<Rigidbody>());
            Destroy(GetComponent<Collider>());

            //LA DETECTAREA "CHECK"-ULUI INREGISTRAM SCRIPTUL ACESTUIA CA SI BAZA DE DATE
            if (Physics.Raycast(transform.position, -transform.up, out recDown, 2000))
            {
                if (recDown.collider)
                {
                    if (recDown.collider.name == "check")
                    {
                        snts = recDown.collider.GetComponent<env>();

                        if (bomba_pulii == 0)
                        {
                            //DUPA  CE FIECARE ENN DETECTEAZA "CHECUL" VA REZULTA NUMARUL TOTAL AL ACESTORA DIN NAV_SCENE-UL IMPLICAT
                            snts.enns_number = snts.enns_number + 1;
                            agent.avoidancePriority = snts.enns_number;
                            diff = snts.enns_number * 0.02f;
                            //Debug.Log(diff);


                            bomba_pulii = 1;
                        }
                    }
                }
            }
           
            //NUMARUL DE REPS DINSCENA
            largimea = snts.move_array.Count;

            //DIRECTIA CATRE EGO
            dirLookEgo = egos.transform.position - transform.Find("enn_shoot_dummie").transform.position;

            //DIRECTIA DE MERS IN NAVIGARE
            dirMers = new Vector3(GetComponent<UnityEngine.AI.NavMeshAgent>().steeringTarget.x, 0.0f, GetComponent<UnityEngine.AI.NavMeshAgent>().steeringTarget.z) - new Vector3(transform.position.x, 0.0f, transform.position.z);
            //dirMers = (GetComponent<NavMeshAgent>().steeringTarget - transform.position);
            //Debug.DrawRay(mesh_agent.transform.position, dirMers, Color.blue);

            //DIATANTA PANA LA EGO
            distance = dirLookEgo.magnitude;//distanta pana la ego

            //CONTACT VIZIAL CU EGO

            //Debug.DrawRay(transform.Find("enn_shoot_dummie").transform.position, dirLookEgo, Color.green);
            if (Physics.Raycast(transform.Find("enn_shoot_dummie").transform.position, dirLookEgo, out recFw, 200.0f))
            {
                if (recFw.collider)
                {
                    if (recFw.collider.name == "sense_ego")
                    {
                        contact_visual = 1; ;//returneaza "contact_vizual" valabil pentru toate distantele
                    }

                    if (recFw.collider.name != "sense_ego")
                    {
                        contact_visual = 0; ;
                    }
                }  
            }

            if (contact_visual == 1 && distance <= 50.0f && orientare_0.pauza == 0)
            {
                aproape = 1;
            }
            if (contact_visual == 0 || distance > 80.0f || orientare_0.pauza == 1)
            {
                aproape = 0;//returneaza "aproape" care este un contact vizual intre anumite limite de distanta
            }



            if (mesh_agent)
            {
                //agent.radius = 0.1f;
                //COMPORTAMENTELE
                heading_ego_hide(40);
                heading_ego_hide_test();
                heading_patrol_point(60);
                heading_ego_view(20);
                inert_agent_enabled_false();
                action_choose(180);
                action_patrol(60);
                lookfor_patrol_point(60);
                lookfor_ego_view(60);
                interm_target_la_vedere();
                lookfor_ego_hide(60);
                interm_target_in_afara_vederii();
                surprins();
                deplasare_spre_ego();
                loveste();
                pacalit();

                mesh_agent.transform.position = transform.position - new Vector3(0.0f, 1.0f, 0.0f);
            }
            

           // infos();
        }
    }
}
