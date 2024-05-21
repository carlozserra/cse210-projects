public class Word {

    private string _text;

    private bool _isHidden;

    public Word (string text) 
    {
         _text = text;
         _isHidden = false;
        
    }

    public void Hide()  // it just indicate the word that should be hidden but it not hides them
    {
        _isHidden = true;
    }

    public void Show()  // it just indicate the word that should be showed but it not shows them
    {
       _isHidden = false;
    }

    public bool IsHidden() 
    {
        return _isHidden;
    }
    
    public string GetDisplayText()  //should return word if visible or underlines if is hidden
    {
         if (_isHidden)
            return new string('_', _text.Length);
        else
            return _text;
    } 

}  // Keeps track of a single word and whether it is shown or hidden.