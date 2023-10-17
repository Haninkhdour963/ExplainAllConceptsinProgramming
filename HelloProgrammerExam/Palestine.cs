namespace HelloProgrammerExam
{
    class Palestine : Country
    {
        /*Remember from the Inheritance chapter that we use the : symbol to inherit from a class,
         * and that we use the override keyword to override the base class method.*/
        public override void CitySound()
        {

            Console.WriteLine("Palestine is the voice of the Freedom");
        
        }
        public void CapitalCountry()
        {

            Console.WriteLine("the Capital of Palestine is Jerusalem");
        }

    }
}