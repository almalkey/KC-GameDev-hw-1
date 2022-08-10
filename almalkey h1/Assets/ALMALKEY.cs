using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALMALKEY : MonoBehaviour
{
    int health = 100;
    int damagedhealth;
    int boostedhealth;

    // Start is called before the first frame update
    void Start()
    {
        damagedhealth = damage();
        boostedhealth = boost();
        if(damagedhealth > boostedhealth)
        {
            print(damagedhealth);
        }
        else if(damagedhealth < boostedhealth)
        {
            print(boostedhealth);
        }
        else
        {
            print(damagedhealth + "end" + boostedhealth);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    int damage ()
    {
        return health - 20;
    }
    int boost ()
    {
        return damagedhealth + 10;
    }




}
