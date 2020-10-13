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
        }

        /****************************** METHODS ******************************/
        public void Fall()
        {
            Console.WriteLine("I'm falling");
        }

        public void ChangeToAutumnColors(int _randomColor)
        {
            // Ca ne marche pas car ce n'est pas la meme instance de random
            // int randomColor = new Random().Next(1, 4);

            switch (_randomColor)
            {
                case 1:
                    Console.WriteLine("I'm changing from green to yellow");
                    leafColor = EnumColor.Yellow;
                    break;
                case 2:
                    Console.WriteLine("I'm changing from green to orange");
                    leafColor = EnumColor.Orange;
                    break;
                default:
                    Console.WriteLine("I'm changing from green to red");
                    leafColor = EnumColor.Red;
                    break;
            }
        }

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