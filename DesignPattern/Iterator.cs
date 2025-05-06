using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    interface IIterator <T>
    {
        bool HasNext();
        T Next();
    }
    public class Aggregate
    {
        List<string>Library=new List<string>();
        public string Iteration()
        {
            return "wait";
        }
        public int TotalBooks() => Library.Count;
        public void AddBook(string library)
        {
            Library.Add(library);
        }
        public string GetName (int Index) => Library[Index];
        public void Remove(string library)
        {
            Library.Remove(library);
        }
    }
    public class Iterator : IIterator<string>
    {
        private int index = 0;
        private Aggregate Dummy;
        public bool HasNext() => index < Dummy.TotalBooks();
        public Iterator(Aggregate Dummy)
        {
            this.Dummy = Dummy;
        }
        public string Next()
        {
            if (HasNext())
            {
                return Dummy.GetName(index++);
            }
            else return null;
        }
    }
}
