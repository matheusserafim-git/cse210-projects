
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {

       
        _reference = reference;
        //divide the text in words and make objects
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;
        List<int> availableIndexes = new List<int>();
    for (int i = 0; i < _words.Count; i++)
    {
        if (!_words[i].IsHidden())
            availableIndexes.Add(i);

    }
        while (hiddenCount < numberToHide && availableIndexes.Count > 0)
        {
            int idx = rand.Next(availableIndexes.Count);
            int wordIndex = availableIndexes[idx];
            _words[wordIndex].Hide();
            availableIndexes.RemoveAt(idx);
            hiddenCount++;
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());

        }
        return _reference.GetDisplayText() + " " + string.Join(" ", displayWords);
    }
    
}