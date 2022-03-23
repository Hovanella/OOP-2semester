using System;
using System.Windows.Forms;
using Laba2.Memento;

namespace Laba2
{
    public partial class MementoForm : Form
    {
        private readonly MementoTextBox _mementoTextBox = new MementoTextBox(string.Empty);

        public MementoForm()
        {
            InitializeComponent();
        }

        private void AddStateButton_Click(object sender, EventArgs e)
        {
            string stateText = AddStateTextBox.Text;
            _mementoTextBox.Change(stateText);
            CurrentStateTextBox.Text = _mementoTextBox.Text;
        }


        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (_mementoTextBox.Undo() != null)
                CurrentStateTextBox.Text = _mementoTextBox.Text;
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (_mementoTextBox.Redo() != null)
                CurrentStateTextBox.Text = _mementoTextBox.Text;
        }

        private void MementoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            (sender as MementoForm).Hide();
        }
    }
}