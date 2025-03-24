using System;
using System.Collections.Generic;

class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16), new List<string>
            {
                "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
            }),
            
            new Scripture(new Reference("Proverbs", 3, 5, 6), new List<string>
            {
                "Trust in the Lord with all your heart and lean not on your own understanding;",
                "In all your ways submit to him, and he will make your paths straight."
            }),
            
            new Scripture(new Reference("Philippians", 4, 13), new List<string>
            {
                "I can do all things through Christ who strengthens me."
            }),
            
            new Scripture(new Reference("Isaiah", 40, 31), new List<string>
            {
                "But those who hope in the Lord will renew their strength.",
                "They will soar on wings like eagles; they will run and not grow weary, they will walk and not be faint."
            }),

            new Scripture(new Reference("Psalm", 23, 1, 2), new List<string>
            {
                "The Lord is my shepherd, I lack nothing.",
                "He makes me lie down in green pastures, he leads me beside quiet waters."
            })
        };
    }

    public Scripture GetRandomScripture()
    {
        return _scriptures[_random.Next(_scriptures.Count)];
    }
}