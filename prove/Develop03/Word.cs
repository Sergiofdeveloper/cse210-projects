class Word
{   //stores text in the scripture reference
    private string text; 
    // boolean attribute shows if the word is hidden or not
    private bool wordHidden; 
    //constructor gets parameter text
    public Word(string text) 
    {   //sets value for text to attribute text
        this.text = text; 
        // default value for hidden. words are not hidden from start
        wordHidden = false; 
    }


    //function returns the text stored in attribute text
    public string ShowText() 
    {
        return text;
    }
    //checks if the word its hidden or not
    public bool WordHidden
    {
        get { return wordHidden; }
    }
    //function sets value for hidden as true. means word is hidden
    public void Hide()
    {
        wordHidden = true;
    }
}