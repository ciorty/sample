using UnityEngine;
using System.Collections;

public class hit_enn_zombie : MonoBehaviour
{	
	public float inPush;
	public int once;
    public int once_rel;
    public int arma;
	public int norm_1;
    public int r_index;
    public string inermediar;
    public Transform fff;
    public GameObject particle4;
    ParticleSystem stars4;
    public GameObject prefabSound_0;
    public GameObject prefabSound_k;
    public string nameParent;
    public env snts;
    public int sd_index;
    public GameObject parent_of_this;
    public GameObject mesh_animated;
    public int inert;
    public GameObject to_hit;
    public Vector3 bullet;
    public int force_active;
    public int vieti;
    public GameObject pre2;
    GameObject particle;
    ParticleSystem stars3;
    public GameObject to_disable_1;
    public GameObject to_disable_2;
    public GameObject parintele;
    GameObject oasele;
    int once_oase;
    int once_hit;
    public int intre_noi;
    public Component[] bones;

    GameObject ost2;

    int ygrec;

    void Start ()
    {
        //ygrec = -5.0f;
        once = 0;
        // particle = (GameObject)Resources.Load("WFX_BImpact Sand", typeof(GameObject));
        // stars3 = particle.GetComponent<ParticleSystem>();
        // pre2 = (GameObject)Resources.Load("BloodMist", typeof(GameObject));
        oasele = (GameObject)Resources.Load("tth", typeof(GameObject));
       
    }

    public void shoot()
    {

    }
    
    void OnTriggerEnter(Collider collision)
    {

        // if (collision.tag == "sense_enn")
        // {
        //     intre_noi = 1;
        // }
        //gameObject.layer = "Untagged";

        if (collision.tag == "sword")
        {
            if(once_hit == 0)
            {
                inert = 1;

                GameObject st2;
                st2 = Instantiate(particle4, transform.position, Quaternion.identity);
                Destroy(st2.gameObject, 2.0f);

                Destroy(mesh_animated);
                collision.gameObject.tag = "non_sword";
                //Destroy(collision.gameObject, 0.5f);

                /*
                recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti = recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti + 1;
                if (recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti >= 1)
                {
                    recDown.collider.gameObject.GetComponent<hit_enn_zombie>().inert = 1;
                    recDown.collider.gameObject.GetComponent<hit_enn_zombie>().bullet = transform.forward;

                    chose_action = Random.Range(0, 4);
                    prefabSound_0 = (GameObject)Resources.Load("impact_" + chose_action + "_sound", typeof(GameObject));
                    GameObject instanceSound_0;
                    instanceSound_0 = Instantiate(prefabSound_0, transform.position, transform.rotation) as GameObject;
                    Destroy(instanceSound_0.gameObject, 2.0f);
                }
                */
                once_hit = 1;
            }

        }

        if (collision.tag == "sword_2")
        {
            if (once_hit == 0)
            {
                inert = 2;

                GameObject st2;
                st2 = Instantiate(particle4, transform.position, Quaternion.identity);
                Destroy(st2.gameObject, 2.0f);

                Destroy(mesh_animated);
                collision.gameObject.tag = "non_sword";
                Destroy(collision.gameObject, 0.5f);

                /*
                recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti = recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti + 1;
                if (recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti >= 1)
                {
                    recDown.collider.gameObject.GetComponent<hit_enn_zombie>().inert = 1;
                    recDown.collider.gameObject.GetComponent<hit_enn_zombie>().bullet = transform.forward;

                    chose_action = Random.Range(0, 4);
                    prefabSound_0 = (GameObject)Resources.Load("impact_" + chose_action + "_sound", typeof(GameObject));
                    GameObject instanceSound_0;
                    instanceSound_0 = Instantiate(prefabSound_0, transform.position, transform.rotation) as GameObject;
                    Destroy(instanceSound_0.gameObject, 2.0f);
                }
                */
                once_hit = 1;
            }

        }

        if (collision.tag == "glont_ego" || collision.tag == "glont_big")
        {
            if (once_hit == 0)
            {
                inert = 1;
                
                GameObject st2;
                st2 = Instantiate(particle4, transform.position, Quaternion.identity);
                Destroy(st2.gameObject, 2.0f);

                Destroy(mesh_animated);
                Destroy(collision.gameObject);
                /*
                inert = 2;

                GameObject st2;
                st2 = Instantiate(particle4, transform.position, Quaternion.identity);
                Destroy(st2.gameObject, 2.0f);
                */

                /*
                recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti = recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti + 1;
                if (recDown.collider.gameObject.GetComponent<hit_enn_zombie>().vieti >= 1)
                {
                    recDown.collider.gameObject.GetComponent<hit_enn_zombie>().inert = 1;
                    recDown.collider.gameObject.GetComponent<hit_enn_zombie>().bullet = transform.forward;

                    chose_action = Random.Range(0, 4);
                    prefabSound_0 = (GameObject)Resources.Load("impact_" + chose_action + "_sound", typeof(GameObject));
                    GameObject instanceSound_0;
                    instanceSound_0 = Instantiate(prefabSound_0, transform.position, transform.rotation) as GameObject;
                    Destroy(instanceSound_0.gameObject, 2.0f);
                }
                */
                once_hit = 1;
            }
        }
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.tag == "glont_ego" || collision.tag == "glont_big")
        {
            //once = 0;
        }
    }


    void treci()
    {


    }
    

    void Update()
    {
        if(inert == 1)
        {
            ygrec = ygrec + 1;
            force_active = force_active + 1;
            transform.parent.gameObject.GetComponent<zbb_civil>().inert = 1;
            if (mesh_animated)
            {
                mesh_animated.GetComponent<bones_zb_control>().inert = 1;
            }

            if(once_oase == 0)
            {
                ost2 = Instantiate(oasele, transform.position, Quaternion.identity);
                ost2.transform.Find("ego_mesh").GetComponent<Renderer>().material.mainTexture = transform.parent.gameObject.GetComponent<zbb_civil>().myT;

                DestroyImmediate(oasele.transform.Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1").GetComponent<CharacterJoint>(), true);
                DestroyImmediate(oasele.transform.Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1/Bip001 Spine2/Bip001 Neck/Bip001 Head").GetComponent<CharacterJoint>(), true);

                Invoke("treci", 2.0f);
                once_oase = 1;
            }

            if(ygrec >= 300)
            {
                bones = ost2.GetComponentsInChildren<Rigidbody>();
                //GetComponent<Rigidbody>().isKinematic = false;
                foreach (Rigidbody ragdoll in bones)
                {
                    ragdoll.isKinematic = true;
                    //ragdoll.GetComponent<Collider>().isTrigger = true;
                    ragdoll.transform.position = new Vector3(ragdoll.transform.position.x, ragdoll.transform.position.y - 0.01f, ragdoll.transform.position.z);
                }
            }

            if (ygrec >= 400)
            {
                Destroy(ost2);
                Destroy(transform.parent.gameObject);
            }
        }

        if (inert == 2)
        {
            ygrec = ygrec + 1;
            force_active = force_active + 1;
            transform.parent.gameObject.GetComponent<zbb_civil>().inert = 1;
            if (mesh_animated)
            {
                mesh_animated.GetComponent<bones_zb_control>().inert = 1;
            }

            if (once_oase == 0)
            {
                ost2 = Instantiate(oasele, transform.position, Quaternion.identity);
                ost2.transform.Find("ego_mesh").GetComponent<Renderer>().material.mainTexture = transform.parent.gameObject.GetComponent<zbb_civil>().myT;

                //DestroyImmediate(oasele.transform.Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1").GetComponent<CharacterJoint>(), true);
                //DestroyImmediate(oasele.transform.Find("Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Spine1/Bip001 Spine2/Bip001 Neck/Bip001 Head").GetComponent<CharacterJoint>(), true);

                Invoke("treci", 2.0f);
                once_oase = 1;
            }

            if (ygrec >= 300)
            {
                bones = ost2.GetComponentsInChildren<Rigidbody>();
                //GetComponent<Rigidbody>().isKinematic = false;
                foreach (Rigidbody ragdoll in bones)
                {
                    ragdoll.isKinematic = true;
                    //ragdoll.GetComponent<Collider>().isTrigger = true;
                    ragdoll.transform.position = new Vector3(ragdoll.transform.position.x, ragdoll.transform.position.y - 0.01f, ragdoll.transform.position.z);
                }
            }

            if (ygrec >= 400)
            {
                Destroy(ost2);
                Destroy(transform.parent.gameObject);
            }
        }
    }
}
