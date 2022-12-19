using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheild : MonoBehaviour
{
    [Header("Set in inspector")]
    public float rotationsPerSecond = 0.1f;

    [Header("Set Dynamically")]
    public int levelShown = 0;

    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        int currentLevel = Mathf.FloorToInt(Player.S.sheildlevel);

        if (levelShown != currentLevel)
        {
            levelShown = currentLevel;
            mat.mainTextureOffset = new Vector2(0.2f * levelShown, 0);
        }
        float rz = -(rotationsPerSecond * Time.time * 360) % 360f;
        transform.rotation = Quaternion.Euler(0, 0, rz);
    }
}
