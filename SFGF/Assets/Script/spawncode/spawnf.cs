using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnf : MonoBehaviour
{
    GameObject clonef1;
    GameObject clonef2;
    GameObject clonef3;

    public GameObject outF1fabs;
    public GameObject outF2fabs;
    public GameObject outF3fabs;

    int f1random;
    int f2random;
    int f3random;

    public Transform f1out;
    public Transform f2out;
    public Transform f3out;
    public Transform f1out2;
    public Transform f2out2;
    public Transform f3out2;
    public Transform f1out3;
    public Transform f2out3;
    public Transform f3out3;

    public void RadomNam()
    {
        f1random = Random.Range(1, 10);
        do
        {
            f2random = Random.Range(1, 10);
        } while (f1random == f2random);
        do
        {
            f3random = Random.Range(1, 10);
        } while (f2random == f3random || f1random == f3random);
    }
    public void GenerateF()
    {
        clonef1 = Instantiate(outF1fabs);
        clonef2 = Instantiate(outF2fabs);
        clonef3 = Instantiate(outF3fabs);
        if (f1random == 1)
        {
            clonef1.transform.position = f1out.position;
        }
        else if (f1random == 2)
        {
            clonef1.transform.position = f2out.position;
        }
        else if (f1random == 3)
        {
            clonef1.transform.position = f3out.position;
        }
        else if (f1random == 4)
        {
            clonef1.transform.position = f1out2.position;
        }
        else if (f1random == 5)
        {
            clonef1.transform.position = f2out2.position;
        }
        else if (f1random == 6)
        {
            clonef1.transform.position = f3out2.position;
        }
        else if (f1random == 7)
        {
            clonef1.transform.position = f1out3.position;
        }
        else if (f1random == 8)
        {
            clonef1.transform.position = f2out3.position;
        }
        else if (f1random == 9)
        {
            clonef1.transform.position = f3out3.position;
        }
        if (f2random == 1)
        {
            clonef2.transform.position = f1out.position;
        }
        else if (f2random == 2)
        {
            clonef2.transform.position = f2out.position;
        }
        else if (f2random == 3)
        {
            clonef2.transform.position = f3out.position;
        }
        else if (f2random == 4)
        {
            clonef2.transform.position = f1out2.position;
        }
        else if (f2random == 5)
        {
            clonef2.transform.position = f2out2.position;
        }
        else if (f2random == 6)
        {
            clonef2.transform.position = f3out2.position;
        }
        else if (f2random == 7)
        {
            clonef2.transform.position = f1out3.position;
        }
        else if (f2random == 8)
        {
            clonef2.transform.position = f2out3.position;
        }
        else if (f2random == 9)
        {
            clonef2.transform.position = f3out3.position;
        }
        if (f3random == 1)
        {
            clonef3.transform.position = f1out.position;
        }
        else if (f3random == 2)
        {
            clonef3.transform.position = f2out.position;
        }
        else if (f3random == 3)
        {
            clonef3.transform.position = f3out.position;
        }
        else if (f3random == 4)
        {
            clonef3.transform.position = f1out2.position;
        }
        else if (f3random == 5)
        {
            clonef3.transform.position = f2out2.position;
        }
        else if (f3random == 6)
        {
            clonef3.transform.position = f3out2.position;
        }
        else if (f3random == 7)
        {
            clonef3.transform.position = f1out3.position;
        }
        else if (f3random == 8)
        {
            clonef3.transform.position = f2out3.position;
        }
        else if (f3random == 9)
        {
            clonef3.transform.position = f3out3.position;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        RadomNam();
        GenerateF();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Random.Range(1, 10));
    }
}
