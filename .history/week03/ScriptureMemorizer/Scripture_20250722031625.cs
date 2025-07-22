using System;
public class Scripture
{
    private Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word w = new Word(word);
            _words.Add(w);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide] = 

    }

    public string GetDisplayText()
    {
        foreach (Word in _words) {
            
        }
    }
    public bool IsCompletelyHidden()
    {
        
    }

}