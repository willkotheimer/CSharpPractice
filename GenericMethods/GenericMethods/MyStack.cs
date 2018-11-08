using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethods
{
    public class MyStack<T>
    {
        private List<T> _list = new List<T>();

        public void Push(T value)
        {
            _list.Add(value);
        }
        public bool IsEmpty()
        {
            return _list.Count == 0;
        }
        public T Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            } else
            {
                T value = _list[_list.Count - 1];
                _list.RemoveAt(_list.Count - 1);
                return value;
            }
        }

        public void readList()
        {
            foreach(var i in _list)
            {
                Console.WriteLine(i);
            }
        }
        public void UnShift(T value)
        {
            List<T> _listholder = new List<T>();
            foreach (var i in _list)
            {
                _listholder.Add(i);
            }

            _list.Clear();
            _list.Add(value);
            foreach(var i in _listholder)
            {
                _list.Add(i);
            }

        }

        public T Shift()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                
                T value = _list.FirstOrDefault();
                _list.RemoveAt(0);

                return value;
            }
        }
           
    }
}
