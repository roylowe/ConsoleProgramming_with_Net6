namespace ClassesAndObjects
{
    internal static class DateUtil
    {
        public static int YearofBirth(int age)
        {
            return DateTime.Now.Year - age;
        }

        public static int YearofBirth(DateTime dateofBirth)
        {
           
            if (dateofBirth == null)
            {
                
                return dateofBirth.Year;
            }
            return 0;

        }
    }
}



//Ctrl+K+e  removes all uneeded using statements  in csharp 10