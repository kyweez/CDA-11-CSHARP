using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FOREST.ClassLibrary
{
    public class Tree : IList
    {

        /***************************** ATTRIBUTES ****************************/
        int HeightInMm;
        private List<Leaf> leafTab;

        /**************************** CONSTRUCTORS ***************************/
        public Tree(int HeightInMm)
        {
            this.HeightInMm = HeightInMm;
            leafTab = new List<Leaf>();
        }

        /***************************** PROPERTIES ****************************/
        public int HeightInCm
        {
            get => HeightInMm;
        }

        public List<Leaf> LeafTab
        {
            get => leafTab;
        }

        /****************************** METHODS ******************************/
        /// <summary>
        /// This method adds a new Leaf on the current tree
        /// </summary>
        /// <param name="_leafColor">EnumColor</param>
        /// <param name="_leafShape">EnumLeafShape</param>
        /// <param name="_leafNumber">int</param>
        /// <returns>void</returns>
        public void AddLeaf(EnumColor _leafColor, EnumLeafShape _leafShape, int _leafNumber)
        {
            int i;
            Random randomNumber;

            i = 0;
            randomNumber = new Random();

            while (i++ < _leafNumber)
            {
                Console.WriteLine($"{i} - Adding a new leaf...");
                leafTab.Add(new Leaf(randomNumber.Next(10, 100), _leafColor, _leafShape));
            }
        }

        public override string ToString()
        {
            String info;

            info = $"Tree Class  : {base.ToString()}\n" +
                   $"Tree height : {HeightInMm} mm\n";

            foreach (Leaf leafOccurence in leafTab)
            {
                info += $"\n{leafOccurence}\n";
            }
            return info;
        }

        public void ChangeToAutumnColors()
        {
            Random randomColor;

            randomColor = new Random();

            foreach (Leaf _leaf in this.LeafTab)
                _leaf.ChangeToAutumnColors(randomColor.Next(1, 4));
        }

        public Leaf this[int i]
        {
            get
            {
                return LeafTab.ElementAt(i);
            }
        }

        /****************************** INTERFACES ******************************/

        public int Count
        {
            get
            {
                return leafTab.Count;
            }
        }

        public bool IsReadOnly => throw new NotImplementedException();
        public bool IsFixedSize => throw new NotImplementedException();
        public object SyncRoot => throw new NotImplementedException();
        public bool IsSynchronized => throw new NotImplementedException();
        object IList.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Add(object value) => throw new NotImplementedException();
        public bool Contains(object value) => throw new NotImplementedException();
        public void Clear() => throw new NotImplementedException();
        public int IndexOf(object value) => throw new NotImplementedException();
        public void Insert(int index, object value) => throw new NotImplementedException();
        public void Remove(object value) => throw new NotImplementedException();
        public void RemoveAt(int index) => throw new NotImplementedException();
        public void CopyTo(Array array, int index) => throw new NotImplementedException();
        public IEnumerator GetEnumerator() => throw new NotImplementedException();
    }
}