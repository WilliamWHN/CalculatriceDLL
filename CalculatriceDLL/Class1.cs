using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public class Calculator
    {
        #region private attributes
        private static char[] operateur = new char[] { ' ', '+', '-', '*', '/' };
        private static float operande1 = 6;
        private static float operande2 = 18;
        private static int operation = 1;
        private static float resultat = 0;
        #endregion private attributes
        public float Add(float op1, float op2)
        {
            return op1 + op2;
        }
        public float Sub(float op1, float op2)
        {
            return op1 - op2;
        }
        public float Divide(float op1, float op2)
        {
            return op1 / op2;
        }
        public float Time(float op1, float op2)
        {
            return op1 * op2;
        }



    }
}
