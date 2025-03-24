using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference _reference;
    private List<List<Word>> _verses;  
    private Random _random = new Random();

    public Scripture(Reference reference, List<string> versesText)
    {
        _reference = reference;
        _verses = versesText.Select(verse => verse.Split(' ').Select(word => new Word(word)).ToList()).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        var allWords = _verses.SelectMany(v => v).Where(w => !w.IsHidden()).ToList();
        var wordsToHide = allWords.OrderBy(x => _random.Next()).Take(numberToHide);
        
        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string versesText = string.Join("\n", _verses.Select(v => string.Join(" ", v.Select(word => word.GetDisplayText()))));
        return $"{referenceText} - {versesText}";
    }

    public bool IsCompletelyHidden()
    {
        return _verses.All(verse => verse.All(word => word.IsHidden()));
    }
}