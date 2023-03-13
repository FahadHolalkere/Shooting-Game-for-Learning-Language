using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text name;
    public int number=0;
    public GameObject gameover;
    [ContextMenu("name")]
    public void assign()
    {
        var list = new List<string>();
        list.Add("Apple");
        list.Add("Mother");
        list.Add("Brother");
        list.Add("Sister");
        list.Add("New");
        list.Add("Father");
        list.Add("Small");
        list.Add("Large");
        list.Add("No");
        list.Add("Yes");
        list.Add("Here");
        list.Add("Again");
        list.Add("Always");
        var list1 = new List<string>();
        list1.Add("Apfel");
        list1.Add("Mutter");
        list1.Add("Bruder");
        list1.Add("Schwester");
        list1.Add("Neu");
        list1.Add("Vater");
        list1.Add("Klein");
        list1.Add("groß");
        list1.Add("Nein");
        list1.Add("Ja");
        list1.Add("Hier");
        list1.Add("Nochmal");
        list1.Add("Stets");
        if(number<13)
        {
            name.text = list[number].ToString() + " = " +list1[number].ToString();
            
            number++;
        }
        else
        {
            number=0;
            name.text = list[number].ToString() + " = " +list1[number].ToString();
            number++;
        }
    }
    
    public void gover()
    {
        SceneManager.LoadScene("gameovers");
    }
    public void displayover()
    {
        gameover.SetActive(true);
    }
    
}
