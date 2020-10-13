using System;
using System.Collections.Generic;


namespace FOREST.ClassLibrary
{
    public class Tree
    {

        /***************************** ATTRIBUTES ****************************/
        int height;
        private List<Leaf> leafTab;

        /**************************** CONSTRUCTORS ***************************/
        public Tree(int height)
        {
            this.height = height;
            leafTab = new List<Leaf>();
        }

        /***************************** PROPERTIES ****************************/
        public int Height
        {
            get => height;
            //set => height = value; 
        }
        public List<Leaf> LeafTab
        {
            get => leafTab;
            //set => leafTab = value; 
        }

        /****************************** METHODS ******************************/
        public void AddLeaf(Leaf f)
        {
            leafTab.Add(f);
        }

        public override string ToString()
        {
            String info;
            
            info = $"{base.ToString()}\n{height}";
            foreach (Leaf leafOccurence in leafTab)
            {
                info += $"\n{leafOccurence.ToString()}";
            }
            return info;
        }
    }
}