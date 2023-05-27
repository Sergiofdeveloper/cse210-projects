class Reference

{
    private string referenceVerse; //text in the scripture reference
    
    // Constructor gets the reference for the scripture
    public Reference(string referenceVerse) 
    {
        this.referenceVerse = referenceVerse;  // set the value of the atribute 
    }

    // function returns the text of the scripture reference stored in the atribute referenceVerse
    public string GetReferenceVerse()  
    {
        return referenceVerse;
    }
}