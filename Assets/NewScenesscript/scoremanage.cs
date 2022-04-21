using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class scoremanage : MonoBehaviour
{
    public TextMeshProUGUI scores;
    public int scoreno = 0;

    // Update is called once per frame
    void Update()
    {
        scores.text = scoreno.ToString();
    }
}
