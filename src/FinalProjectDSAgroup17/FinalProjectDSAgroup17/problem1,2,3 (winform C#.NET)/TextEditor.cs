using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalDataStructure
{
    internal class TextEditor
    {
        private MyStack<string> undoStack;  // Stack to store previous text states
        private MyStack<string> redoStack;  // Stack to store undone actions
        private string currentText;

        public TextEditor()
        {
            undoStack = new MyStack<string>();
            redoStack = new MyStack<string>();
            currentText = string.Empty;
        }

        // Get the current text
        public string GetCurrentText()
        {
            return currentText;
        }

        // Type or modify text
        public void TypeText(string newText)
        {
            // Save the current text to the undo stack before modifying
            undoStack.Push(currentText);
            redoStack = new MyStack<string>();  // Clear redo stack after new text
            currentText = newText;
        }

        // Undo the last text change
        public bool Undo()
        {
            if (!undoStack.IsEmpty())
            {
                // Push the current text to the redo stack before undoing
                redoStack.Push(currentText);
                currentText = undoStack.Pop();
                return true;
            }
            return false;
        }

        // Redo the last undone text change
        public bool Redo()
        {
            if (!redoStack.IsEmpty())
            {
                // Push the current text to the undo stack before redoing
                undoStack.Push(currentText);
                currentText = redoStack.Pop();
                return true;
            }
            return false;
        }
        public bool UndoStackIsEmpty()
        {
            return undoStack.IsEmpty();
        }
        public bool RedoStackIsEmpty()
        {
            return undoStack.IsEmpty();
        }

    }
}
