using System;
public class Scripture
{
    private Reference _reference = new Reference("",0,0);
    public List<Word> _words = new List<Word>();

    public Scripture()
    {


    }
    public Scripture(Reference reference, string text)
    {
        string[] words = text.Split(" ");
        foreach (string word in words )
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {

    }
    public bool IsCompletelyHidden()
    {
        
    }
}