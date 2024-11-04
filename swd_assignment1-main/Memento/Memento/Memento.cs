using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_namespace
{
    public class Memento
    {
        private string _state { get; }

        public Memento(string state)
        {
            this._state = state;
        }

        public string State { get { return _state; } }
        

    }
}
