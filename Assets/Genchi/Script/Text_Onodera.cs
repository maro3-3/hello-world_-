using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Onodera : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text label1,label2, label3, label4;
   public int emp_count;
   private bool employees;
    // public string teststring;
    //public Button button;
    [SerializeField] GameObject Object;
    [SerializeField] GameObject PLAYER;

  

    void Start()
    {
        PLAYER = GameObject.FindGameObjectWithTag("Player");
        employees = false;
        emp_count = 5;
        UpdateCount();
    }
    private void Update()
    {
        
       
    }

    public void OnTriggerStay(Collider other)
    {
        //if (other.gameObject == PLAYER)
        //{
            Object.SetActive(true);
       // }

        if (employees == false)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                emp_count += 1;
                if (emp_count >= 100)
                    emp_count = 100;

            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                emp_count -= 1;
                if (emp_count <= 0)
                    emp_count = 0;

            }


            if (Input.GetKey(KeyCode.Space))
            {
                employees = true;
                label2.text = "";
                label3.text = "";
                label4.text = "";
                Employees();
            }
            UpdateCount();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Object.SetActive(false);
    }

    void UpdateCount()
    {
        if (emp_count <= 100)
        {

            label1.text = emp_count + "l";
        }
    }

    public int Employees()
    {
        int number_employees = 0;
        number_employees = emp_count;
        return number_employees;
    }
}
