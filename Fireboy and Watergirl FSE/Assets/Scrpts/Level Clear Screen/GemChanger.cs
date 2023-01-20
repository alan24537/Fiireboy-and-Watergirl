using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemChanger : MonoBehaviour
{
    public Sprite grey_gem;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerStats.special_gems_per_level[PlayerStats.level] == 1) {
            GetComponent<Image>().sprite = grey_gem;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
