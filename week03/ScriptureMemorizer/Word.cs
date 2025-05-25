public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public string GetDisplayText()
    {
        return _hidden ? "_____" : _text;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
}