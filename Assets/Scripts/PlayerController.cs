using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DynamicSplitScreen.Testing
{
    public class PlayerController : MonoBehaviour
    {
        private Animator animator;
        private Rigidbody2D rigidbody2d;
        private new Rigidbody rigidbody;

        public bool EnableInput = true;
        public string HorizontalAxisName = "Horizontal";
        public string VerticalAxisName = "Vertical";
        public float Speed = 2.5f;
        public bool Alarm = false;

        public int PickedMoney = 0;


        private Manager Mg;

        private GameObject GameManager;
        private GameObject MoneyPickup1;
        private GameObject MoneyPickup2;
        private GameObject MoneyPickup3;
        private GameObject MoneyPickup4;
        private int MoneyValue1;
        private int MoneyValue2;
        private int MoneyValue3;
        private int MoneyValue4;

        private bool is3DCharacter = false;

        private const float GRAVITY_Y = -15f;
        private float yMomentum = 0;

        private void Awake()
        {
            animator = GetComponent<Animator>();
            rigidbody2d = GetComponent<Rigidbody2D>();
            rigidbody = GetComponent<Rigidbody>();

            GameManager = GameObject.Find("GameManager");
            MoneyPickup1 = GameObject.Find("MoneyPickup1");
            MoneyPickup2 = GameObject.Find("MoneyPickup2");
            MoneyPickup3 = GameObject.Find("MoneyPickup3");
            MoneyPickup4 = GameObject.Find("MoneyPickup4");

            Mg = GameManager.GetComponent<Manager>();



            MoneyValue1 = Mg.MoneyValue1;
            MoneyValue2 = Mg.MoneyValue2;
            MoneyValue3 = Mg.MoneyValue3;
            MoneyValue4 = Mg.MoneyValue4;


            if (rigidbody)
            {
                is3DCharacter = true;
            }
        }

        private void OnEnable()
        {
            SplitScreenManager.Instance.RegisterPlayer(transform);
        }

        private void OnDisable()
        {
            SplitScreenManager.Instance.UnregisterPlayer(transform);
        }

        private void Update()
        {
            if (!EnableInput) return;
            
            Vector3 movement;
            if (!is3DCharacter)
            {
                movement = new Vector2(Input.GetAxis(HorizontalAxisName), Input.GetAxis(VerticalAxisName)).normalized * Speed;
                rigidbody2d.velocity = movement;
            }
            else
            {
                // calculate movement
                movement = new Vector3(Input.GetAxis(HorizontalAxisName), 0, Input.GetAxis(VerticalAxisName)).normalized * Speed;
                
                // calculate gravity
                if (IsGrounded())
                {
                    yMomentum = 0;
                }
                else
                {
                    yMomentum += GRAVITY_Y * Time.deltaTime;
                }

                // apply movement
                rigidbody.velocity = movement + new Vector3(0, yMomentum, 0);

                // rotate based on movement
                transform.LookAt(transform.localPosition + movement.normalized);

                // animations
                if (animator) animator.SetFloat("walkSpeed", movement.magnitude / Speed);
            }
        }

        private bool IsGrounded()
        {
            Vector3 origin = transform.position + Vector3.up * .25f;
            RaycastHit[] hits = Physics.RaycastAll(origin, -Vector3.up, 0.3f);

            foreach (RaycastHit hit in hits)
            {
                if (hit.collider != GetComponent<Collider>())
                {
                    // correction
                    transform.position = new Vector3(transform.position.x, hit.point.y + 0.025f, transform.position.z);

                    return true;
                }
            }

            return false;
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.name == "DetectionCone")
            {
                Alarm = true;
            }

            if (other.gameObject == MoneyPickup1)
            {
                PickedMoney += MoneyValue1;
                Destroy(MoneyPickup1);
            }

            if (other.gameObject == MoneyPickup2)
            {
                PickedMoney += MoneyValue2;
                Destroy(MoneyPickup2);
            }

            if (other.gameObject == MoneyPickup3)
            {
                PickedMoney += MoneyValue3;
                Destroy(MoneyPickup3);
            }

            if (other.gameObject == MoneyPickup4)
            {
                PickedMoney += MoneyValue4;
                Destroy(MoneyPickup4);
            }

        }
    }
}
