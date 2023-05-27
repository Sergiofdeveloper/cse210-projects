using System;
using System.Collections.Generic;

class Scripture
{
    private Reference reference;  
    private List<Word> words;  

    public Scripture(string referenceVerse, string scriptureText)  //constructor gets 2 parameters
    {
        reference = new Reference(referenceVerse);  
        words = new List<Word>(); // new empty list
        //iterates through every word and separates them
        foreach (string wordText in scriptureText.Split(' ')) //iterates through every word and separates them
        {
        // iteration creates new instance of Word and adds to list words.
        words.Add(new Word(wordText)); 
        }
    }

    public string GetScripture()   
    {     // variable formattedScripture stores verse
        string formattedScripture = reference.GetReferenceVerse() + ": ";  //gets the text from the verse and separate it form the verse reference
    
    foreach (Word word in words)
    {
        if (word.WordHidden)
        {
            //if word is hidden add _ _
            formattedScripture += "_ _"; 
        }
        else
        {
             //if is not hidden add the text of the word with a blank space
            formattedScripture += word.ShowText() + " "; 
        }
    }
    
    return formattedScripture.Trim(); // use trim to erase blank space at the beggining or at the end of the verse
    }

    public void HideWord()  // picks random word from list words
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index].Hide(); // function Hide from class Word hides chosen word
    }

    public bool everythingHidden() // iterates through every word and checks if is not hidden
    {
        foreach (Word word in words)
        {
            if (!word.WordHidden) // if it´s not hidden returns false
                return false;
        }
        return true;
    }
}