using System;
public class Scripture
{
    private Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        random.Next(1,10 ));
        _words[numberToHide].Hide();

    }

    public string GetDisplayText()
    {
        string script = "";
        foreach (Word word in _words)
        {
            script += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {script}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }

        return true;
    }
    
}


