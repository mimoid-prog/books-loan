namespace UtilityMethods
{
    public static class Utilities
    {
        public static string CreateSafeInteraction(string question, bool isInt = false)
        {
            bool isValid = false;
            string? value = null;

            while (!isValid)
            {
                Console.WriteLine(question);
                value = Console.ReadLine();

                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Nie podales zadnej wartosci. Sprobuj ponownie!");
                }
                else
                {
                    isValid = true;
                }
            }

            if (value == null)
            {
                throw new Exception("Value cannot be null in this place.");
            }
            else
            {
                return value;
            }
        }
    }
}
