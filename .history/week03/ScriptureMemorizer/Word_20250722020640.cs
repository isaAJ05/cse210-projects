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

    v SetWord(String text) {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
    _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden == false)
        {
            return _text;
        }
        else
        {
            return 
        }

    }
}