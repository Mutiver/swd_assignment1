using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_namespace
{
    public class Originator
    {
        private string _state { get; set; }
        private int _currentMementoIndex = 0;
        public Originator(string state) 
        {
            this._state = state;
        }

        public void ChangeState(string newState)
        {
            this._state = newState;
        }


        public void SaveState(Caretaker caretaker)
        {
            caretaker.SaveMemento(CreateMemento());
            _currentMementoIndex = caretaker.GetMementoCount() - 1;
            printState();
        }

        public void Undo(Caretaker caretaker)
        {
            if (_currentMementoIndex > 0)
            {
                _currentMementoIndex--;
                RestoreMemento(caretaker.RetrieveMemento(_currentMementoIndex));
            }
            printState();
        }

        public void Redo(Caretaker caretaker)
        {
            if (_currentMementoIndex < caretaker.GetMementoCount() - 1)
            {
                _currentMementoIndex++;
                RestoreMemento(caretaker.RetrieveMemento(_currentMementoIndex));
            }
            printState();
        }
        private Memento CreateMemento()
        {
            return new Memento(_state);
        }

        private void RestoreMemento(Memento memento)
        {
            _state = memento.State;
        }
        private void printState()
        {
            Console.WriteLine("******************\n");
            Console.WriteLine(_state);
            Console.WriteLine("\n******************\n\n");
        }



    }
}
