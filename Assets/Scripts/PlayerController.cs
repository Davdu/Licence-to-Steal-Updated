using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DynamicSplitScreen.Testing
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D rigidbody2d;

        public bool EnableInput = true;
        public string HorizontalAxisName = "Horizontal";
        public string VerticalAxisName = "Vertical";
        public float Speed = 2.5f;
        public float rotationSpeed = 720f;
        public bool Alarm = false;
        public bool Win = false;

        public int PickedMoney = 0;


        private Manager Mg;
        private GameObject GameManager;
        private GameObject WinZone;


        private void Awake()
        {
            rigidbody2d = GetComponent<Rigidbody2D>();

            GameManager = GameObject.Find("GameManager");
            WinZone = GameObject.Find("WinZone");

            Mg = GameManager.GetComponent<Manager>();
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
            

            // Player movement
            Vector2 movement;   
            movement = new Vector2(Input.GetAxis(HorizontalAxisName), Input.GetAxis(VerticalAxisName)).normalized * Speed;
            rigidbody2d.velocity = movement;
            
            // Player rotation
            if (movement != Vector2.zero)
            {
                Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movement);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            }
            

        }


        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.name == "DetectionCone")
            {
                Alarm = true;
            }

            if (other.gameObject == Mg.MoneyPickup1)
            {
                PickedMoney += Mg.MoneyValue1;
                Destroy(Mg.MoneyPickup1);
            }

            if (other.gameObject == Mg.MoneyPickup2)
            {
                PickedMoney += Mg.MoneyValue2;
                Destroy(Mg.MoneyPickup2);
            }

            if (other.gameObject == Mg.MoneyPickup3)
            {
                PickedMoney += Mg.MoneyValue3;
                Destroy(Mg.MoneyPickup3);
            }

            if (other.gameObject == Mg.MoneyPickup4)
            {
                PickedMoney += Mg.MoneyValue4;
                Destroy(Mg.MoneyPickup4);
            }

            if (other.gameObject == WinZone)
            {
                Win = true;
            }

        }
    }
}
