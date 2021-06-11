using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Button : MonoBehaviour
{
    public TextMeshProUGUI Text1;
    public TextMeshProUGUI Text2;
    public TextMeshProUGUI Text3;
    public TextMeshProUGUI Text4;
    public TextMeshProUGUI Text5;
    public TextMeshProUGUI Text6;
    public TextMeshProUGUI Text7;
    string[] asianFood = new string[]{"Sushi", "Peking Eend", "Bami"};
    string[] hollandsePot = new string[]{"Bloemkool", "Vis en Aardapplekroketjes", "Hachee", "Hutspot"};
    string[] makkelijk = new string[]{"Patat met snack", "Soep met brood", "Pannekoeken", "Broodje hamburger", "Sla"};
    string[] italiaans = new string[]{"Spaghetti", "Zelf gemaakte pizza", "Pasta carbonara", "Lasagne"};
    string[] rijstMaaltijd = new string[]{"Kip tandoori", "Kip siam", "Kip madras", "Nasi"};
    string[] twentyFour = new string[]{"Pasta pesto ovenschotel", "Kip-mangowok", "Moussaka", "Kofte met yoghurt-muntsaus"};
    string[] vega = new string[]{"Couscous", "Ratatouille", "Shakshunka", "Falafel"};

    public void OnClick()
    {
        string showFood1 = asianFood[Random.Range(0, asianFood.Length)];
        SetText1(showFood1);
        string showFood2 = hollandsePot[Random.Range(0, hollandsePot.Length)];
        SetText2(showFood2);
        string showFood3 = makkelijk[Random.Range(0, makkelijk.Length)];
        SetText3(showFood3);
        string showFood4 = italiaans[Random.Range(0, italiaans.Length)];
        SetText4(showFood4);
        string showFood5 = rijstMaaltijd[Random.Range(0, rijstMaaltijd.Length)];
        SetText5(showFood5);
        string showFood6 = twentyFour[Random.Range(0, twentyFour.Length)];
        SetText6(showFood6);
        string showFood7 = vega[Random.Range(0, vega.Length)];
        SetText7(showFood7);
    }


    public void SetText1(string text1)
    {
        Text1.text = "We eten op Maandag: " + text1;
    }
    public void SetText2(string text2)
    {
        Text2.text = "We eten op Dinsdag: " + text2;
    }
    public void SetText3(string text3)
    {
        Text3.text = "We eten op Woensdag: " + text3;
    }
    public void SetText4(string text4)
    {
        Text4.text = "We eten op Donderdag: " + text4;
    }
    public void SetText5(string text5)
    {
        Text5.text = "We eten op Vrijdag: " + text5;
    }
    public void SetText6(string text6)
    {
        Text6.text = "We eten op Zaterdag: " + text6;
    }
    public void SetText7(string text7)
    {
        Text7.text = "We eten op Zondag: " + text7;
    }
    
}
