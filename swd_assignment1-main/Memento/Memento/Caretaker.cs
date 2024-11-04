using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_namespace
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void SaveMemento(Memento memento)
        {
            mementos.Add(memento);
            
        }

        public Memento RetrieveMemento(int index)
        {
            return mementos[index];
        }

        public int GetMementoCount()
        {
            return mementos.Count;
        }

    }
}
