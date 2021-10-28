using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScriptManager : MonoBehaviour
{
    public GameObject GameManager;
    private Manager Mg;
    private EnemyFollow EF;
    private EnemyPatrol EP;
    private Rigidbody2D rb;
    public bool switched = false;

    private void Awake()
    {
        Mg = GameManager.GetComponent<Manager>();
        EF = this.gameObject.GetComponent<EnemyFollow>();
        EP = this.gameObject.GetComponent<EnemyPatrol>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        EF.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Mg.AlarmActive == true )
        {
            switched = true;
            EP.enabled = false;
            EF.enabled = true;
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }


    }
}
