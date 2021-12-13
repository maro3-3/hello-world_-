using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unemployed_Onodera : MonoBehaviour
{
    DataBase database = null;
    [SerializeField] GameObject Object1;
    [SerializeField] GameObject Object2;
    [SerializeField] GameObject Object3;
    public int UnempCountry = 0;//���Ǝ҂̍� 
    public int UnempArea = 0;//���Ǝ҂̒n��@
    public int Unempstate = 1;//���

    int turnget = 0, turncheck = 0;

    // Start is called before the first frame update
    int Arealv;
    int startturn;//��������̃^�[��
    int myturn;//�������Ă���̃^�[��
    void Start()
    {
        database = Resources.Load<DataBase>("DataBase");
        Arealv = Areamanager_Onodera.GetArealv(UnempCountry, UnempArea);
        startturn = database.TurnNum;
        myturn = startturn;
    }



    // Update is called once per frame
    void Update()
    {
        startturn = database.TurnNum;
        turnget = startturn- myturn;
        if (Unempstate == 1)
        {

            if (turnget != turncheck)
            {
                int AreaCheck;//�G���A�̃��x��
                int ran = Random.Range(0, 100);
                turncheck = turnget;
                Arealv = Areamanager_Onodera.GetArealv(UnempCountry, UnempArea);
                AreaCheck = database.countrys[Arealv].AreaLv;
                if (AreaCheck == 1)//�G���A�̃��x����1
                {
                    if (ran < 10 * turnget)
                    {
                        Unempstate = 2;
                        database.unemployed[0].Faint_BreathNum += 1;
                    }
                }
                else if (AreaCheck == 2)
                {
                    if (ran < 9 * turnget)
                    {
                        Unempstate = 2;
                        database.unemployed[0].Faint_BreathNum += 1;
                    }
                }
                else if (AreaCheck == 3)
                {
                    if (ran < 7 * turnget)
                    {
                        Unempstate = 2;
                        database.unemployed[0].Faint_BreathNum += 1;
                    }
                }
                else if (AreaCheck == 4)
                {
                    if (ran < 6 * turnget)
                    {
                        Unempstate = 2;
                        database.unemployed[0].Faint_BreathNum += 1;
                    }
                }
                else if (AreaCheck == 5)
                {
                    if (ran < 4 * turnget)
                    {
                        Unempstate = 2;
                        database.unemployed[0].Faint_BreathNum += 1;
                    }
                }
            }


            Object1.SetActive(true);
            Object2.SetActive(false);
            Object3.SetActive(false);
        }
        if (Unempstate == 2)//���̑�
        {
            if (turnget != turncheck)
            {
                turncheck = turnget;
                Unempstate = 3;
                database.unemployed[0].Death_tollNum += 1;
            }
            Object1.SetActive(false);
            Object2.SetActive(true);
            Object3.SetActive(false);
        }


        if (Unempstate == 3)//���S
        {
            Object1.SetActive(false);
            Object2.SetActive(false);
            Object3.SetActive(true);
        }
    }
}
