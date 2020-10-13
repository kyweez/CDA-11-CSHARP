using System;

namespace FOREST.ClassLibrary
{
    public class Leaf
    {
        /***************************** ATTRIBUTES ****************************/
        int veinNumber;
        EnumColor leafColor;
        EnumLeafShape leafShape;

        /**************************** CONSTRUCTORS ***************************/
        public Leaf(int _veinNumber, EnumLeafShape _leafShape) : this(_veinNumber, EnumColor.Green, _leafShape)
        {

        }

        public Leaf(int _veinNumber, EnumColor _leafColor, EnumLeafShape _leafShape)
        {
            veinNumber = _veinNumber;
            leafColor = _leafColor;
            leafShape = _leafShape;
        }

        /***************************** PROPERTIES ****************************/
        public int NbNervures
        {
            get => veinNumber;
            //set => veinNumber = value; 
        }

        /****************************** METHODS ******************************/
        public void Fall()
        {
            Console.WriteLine("I'm falling");
        }

        public void PrendsTesCouleursDAutomne()
        {
            if (this.leafColor.Equals(EnumColor.Yellow))
            {
                this.leafColor = EnumColor.Red;
            }
            else
            {
                this.leafColor = EnumColor.Yellow;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nVein Number : {veinNumber}\nLeaf Color : {leafColor}\nLeaf Shape : {leafShape}";
        }
    }
}