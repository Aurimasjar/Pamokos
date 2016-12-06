namespace SyntaxTest.Exercises
{
    public class Exercise07
    {
        /*
          Parašykite viešą metodą pavadinimu GetNegative, kuris grąžina int tipo rezultatą. Šis metodas turi turėti vieną int tipo kintamąjį pavadinimu number.

          Parašykite viešą metodą pavadinimu GetHalf, kuris grąžina decimal tipo rezultatą. Šis metodas turi turėti vieną int tipo kintamąjį pavadinimu number.
        */

        public int GetNegative(int number)
        {
            return -number;
        }
        public decimal GetHalf(int number)
        {
            return (decimal) number/2;
        }
    }
}
