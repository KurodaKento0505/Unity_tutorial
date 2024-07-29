using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject prefab;
    private void Awake()
    {
        Instantiate(prefab, this.transform.position, prefab.transform.rotation);
    }
}
