using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word()
    {
        _text = "";
        _isHidden = false;
    }

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {

    }
    public void Show()
    {

    }
    public bool IsHidden()
    {
        _IsHidden = true;
        return true;
    }
    public string GetDisplayText(){

    }
}