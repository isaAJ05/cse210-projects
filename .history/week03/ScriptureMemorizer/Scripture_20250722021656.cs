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
        _words = text.Split(" ");
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