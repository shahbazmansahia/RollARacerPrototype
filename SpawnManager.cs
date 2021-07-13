using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] Buffs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /** So I'm thinking.... the objects should spawn in 'sets', like in an obstacle course; like 3 roads in front to jump to, then the next set has roads where the gaps were, to jump to them...
     * 
     * basically, we won't need random spawns; in fact they will be VERY rigid spawns in specific sets at specific positions
     */
    void spawnObjectSet()
    {
        
    }
}
