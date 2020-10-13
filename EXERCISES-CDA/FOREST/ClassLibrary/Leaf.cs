using System;

namespace FOREST.ClassLibrary
{
    public class Leaf
    {
        /***************************** ATTRIBUTES ****************************/
        int veinNumber;
        EnumLeafColor leafColor;
        EnumLeafShape leafShape;

        /**************************** CONSTRUCTORS ***************************/
        public Leaf(int _veinNumber, EnumLeafColor _leafColor, EnumLeafShape _leafShape)
        {
            veinNumber = _veinNumber;
            leafColor = _leafColor;
            leafShape = _leafShape;
        }

        /***************************** PROPERTIES ****************************/
        // NONE

        /****************************** METHODS ******************************/
        /// <summary>
        /// This methods simulates the leaf fall by writting it on the stdout.
        /// </summary>
        /// <returns>void</returns>
        public void Fall() => Console.WriteLine($"I'm falling, I was a :\n{ToString()}\n");

        /// <summary>
        /// This method will transform any leaf in an autumn leaf
        /// It simulates the change by writting it on the stdout
        /// </summary>
        /// <param name="_randomColor">int</param>
        /// <returns>void</returns>
        public void ChangeToAutumnColors(int _randomColor)
        {
            switch (_randomColor)
            {
                case 1:
                    Console.WriteLine("I'm changing to yellow");
                    leafColor = EnumLeafColor.Yellow;
                    break;
                case 2:
                    Console.WriteLine("I'm changing to orange");
                    leafColor = EnumLeafColor.Orange;
                    break;
                default:
                    Console.WriteLine("I'm changing to red");
                    leafColor = EnumLeafColor.Red;
                    break;
            }
        }

        /// <summary>
        /// This method overrides the native ToString methods
        /// The aim is having a readable display of the object fields
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return
                $"Leaf Class  : {base.ToString()}\n" +
                $"Vein Number : {veinNumber}\n" +
                $"Leaf Color  : {leafColor}\n" +
                $"Leaf Shape  : {leafShape}";
        }
    }
}