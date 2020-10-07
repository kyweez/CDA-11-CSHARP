using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PAPILLON
{
    public class Butterfly : LifeCycleStage
    {
        /******************************** CONSTRUCTORS ********************************/

        public Butterfly()
        {
            IsFlying = false;
        }

        /********************************* PROPERTIES *********************************/

        /// <summary>
        ///     Property (get/set) of the boolean field : isFlying
        /// </summary>
        public bool IsFlying { get; set; }

        /*********************************** METHODS **********************************/

        /// <summary>
        ///     The method writes on the stdout if the butterfly is moving either by flying 
        ///     or walking. The the method returns true
        /// </summary>
        /// <returns>bool</returns>
        public override bool Move()
        {
            if (IsFlying)
            {
                Console.WriteLine("The butterfly is moving by the air");
                return true;
            }
            else
            {
                Console.WriteLine("The butterfly is walking");
                return true;
            }
        }

        /// <summary>
        ///     This prints on the stdout that a butterfly can't evolve and returns false.
        /// </summary>
        /// <returns>bool</returns>
        public override bool Evolve(Lepidoptera _lepidoptera)
        {
            Console.WriteLine("A butterfly can't evolve, or maybe to the death ? =)");
            return false;
        }
    }
}