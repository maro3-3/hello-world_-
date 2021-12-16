using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionFrame : MonoBehaviour
{
    public bool isUse;  // éqÇ…ProductionÇ™Ç†ÇÈèÍçátrue

    [SerializeField] private GameObject ChildProduction;

    // Start is called before the first frame update
    void Start()
    {
        isUse = false;
    }

    public void Init()
    {
        ChildProduction = transform.Find("Production").gameObject;
        if (ChildProduction)
        {
            isUse = true;
        }
        Debug.Log("ê∂éYé“Çê›íu");
    }

    // Update is called once per frame
    void Update()
    {
        if (ChildProduction)
        {
            isUse = true;
        }
        else
        {
        }
        //else Destroy(this.gameObject);
    }
}
