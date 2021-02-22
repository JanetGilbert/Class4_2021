using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClassString
{
    public string name;
}

public struct StructString
{
    public string name;
}


public class RefOut : MonoBehaviour
{

    void Start()
    {
        ClassString myClassString = new ClassString();


        StructString myStructString;


       myClassString.name = "MyClassString";
       myStructString.name = "MyStructString";

       Debug.Log("myClassString.name:" + myClassString.name + " myStructString.name" + myStructString.name);


        BothTypes(myClassString, out myStructString);

        Debug.Log("AFTER myClassString.name:" + myClassString.name + " myStructString.name" + myStructString.name);

    }

    int BothTypes(ClassString a, out StructString b)
    {
        a.name = "Betty";
        b.name = "Veronica";


        return 5;
    }

    void Update()
    {
        
    }
}
