using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            // memento pattern provides the ability to restore an object to its previous state (undo via rollback)
            var mementoList = new List<Memento>();
            var originator = new Originator("state0");
            mementoList.Add(originator.Save());
            originator.ChangeState("state1");
            mementoList.Add(originator.Save());
            originator.Restore(mementoList[0]);
            originator.ShowState(); // state0
        }
    }
}
