namespace Laba2.Memento
{
    public class Memento
    {
        public Memento(string text)
        {
            Text = text;
        }

        public string Text { get; private set; }
    }
}