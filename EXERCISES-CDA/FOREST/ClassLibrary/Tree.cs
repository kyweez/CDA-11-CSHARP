using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FOREST.ClassLibrary
{
    public class Tree : IList
    {

        /***************************** ATTRIBUTES ****************************/
        int heightInMm;
        private List<Leaf> leafTab;

        /**************************** CONSTRUCTORS ***************************/
        public Tree(int HeightInMm)
        {
            this.heightInMm = HeightInMm;
            leafTab = new List<Leaf>();
        }

        /***************************** PROPERTIES ****************************/
        public int HeightInMm
        {
            get => heightInMm;
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
        public void AddLeaf(EnumLeafColor _leafColor, EnumLeafShape _leafShape, int _leafNumber)
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

        /// <summary>
        /// This method overrides the parent ToString method
        /// The aim is having a readable display of the object fields
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            String info;

            info = $"Tree Class  : {base.ToString()}\n" +
                   $"Tree height : {HeightInMm} mm\n";

            foreach (Leaf leafOccurence in leafTab)
                info += $"\n{leafOccurence}\n";
            
            return info;
        }

        /// <summary>
        /// This method changes randomly the color of the green leafs
        /// </summary>
        /// <returns>void</returns>
        public void ChangeToAutumnColors()
        {
            Random randomColor;

            randomColor = new Random();

            foreach (Leaf _leaf in LeafTab)
                _leaf.ChangeToAutumnColors(randomColor.Next(1, 4));
        }

        /// <summary>
        /// This methods trigger the fall of the input leaf and delete it from the tab
        /// </summary>
        /// <param name="_leaf"></param>
        public void LeafFall(Leaf _leaf)
        {
            _leaf.Fall();
            Remove(_leaf);
        }

        /// <summary>
        /// Get the element at the specified index
        /// </summary>
        /// <param name="i">int </param>
        /// <returns>Leaf</returns>
        public Leaf this[int index]
        {
            get =>LeafTab.ElementAt(index);
        }

        /// <summary>
        /// Gets the number of elements contained in the System.Collections.ICollection.
        /// </summary>
        /// <returns>int</returns>
        public int Count
        {
            get => leafTab.Count;
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the System.Collections.IList.
        /// </summary>
        /// <param name="_leaf">object</param>
        public void Remove(object _leaf)
        {
            if (_leaf is null)
                throw new ArgumentNullException(nameof(_leaf));

            LeafTab.Remove((Leaf)_leaf);
        }

        /************************** UNUSED INTERFACES **************************/

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
        public void CopyTo(Array array, int index) => throw new NotImplementedException();
        public IEnumerator GetEnumerator() => throw new NotImplementedException();
        public void RemoveAt(int index) => throw new NotImplementedException();
    }
}