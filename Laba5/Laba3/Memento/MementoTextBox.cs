using System.Collections.Generic;

namespace Laba2.Memento
{
    public class MementoTextBox
    {
        private int _index;
        private readonly List<Memento> _mementoes;
        
        public MementoTextBox(string text)
        {
            _index = 0;
            Text = text;
            _mementoes = new List<Memento>(){new Memento(Text)}; 
        }

        public void Change(string text)
        {
            Text = text;
            _mementoes.Add(new Memento(Text));
            _index++;
        }

        public Memento Undo()
        {
            if (_index <= 0) return null;
            var state = _mementoes[--_index];
            Text = state.Text;
            return state;
        }
        public Memento Redo()
        {
            if (_index+1 >= _mementoes.Count) return null;
            var state = _mementoes[++ _index];
            Text = state.Text;
            return state;
        }
        
        public string Text { get; private set; }
        
       
        
    
    }
}