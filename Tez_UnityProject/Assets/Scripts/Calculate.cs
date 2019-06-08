using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Calculate : MonoBehaviour
{

    public Toggle D;
    public Toggle C;
    public Toggle I;
    public Toggle S;
    static int valueD = 0, 
        valueC = 0, 
        valueI = 0, 
        valueS = 0;

    public void onSelect()
    {
        if (D.isOn)
            valueD += 1;
        else if (C.isOn)
            valueC += 1;
        else if (I.isOn)
            valueI += 1;
        else if (S.isOn)
            valueS += 1;
    }

    public void showResults()
    {
        if (valueD > valueC && valueD > valueS && valueD > valueI)
            SceneManager.LoadScene("D");
        if (valueC > valueD && valueC > valueS && valueC > valueI)
            SceneManager.LoadScene("C");
        if (valueI > valueD && valueI > valueC && valueI > valueS)
            SceneManager.LoadScene("I");
        if (valueS > valueD && valueS > valueI && valueS > valueC)
            SceneManager.LoadScene("S");
        if (valueD == valueI && valueD > valueC && valueD > valueS)
            SceneManager.LoadScene("Di");
        if (valueD == valueC && valueD > valueS && valueD > valueI)
            SceneManager.LoadScene("Dc");
        if (valueD == valueS && valueD > valueC && valueD > valueI)
            SceneManager.LoadScene("Ds");
        if (valueS == valueC && valueS > valueI && valueS > valueD)
            SceneManager.LoadScene("Sc");
        if (valueI == valueS && valueI > valueC && valueI > valueD)
            SceneManager.LoadScene("Is");
        if (valueI == valueC && valueI > valueS && valueI > valueD)
            SceneManager.LoadScene("Ic");

        valueD = 0;
        valueC = 0;
        valueI = 0;
        valueS = 0;
    }
}
