using System;

namespace Assignment2.Adapter
{
    public class ConvertAdapter : IConvertAdapter
    {
        public PrintingInts PrintingInts { get; set; }

        public PrintingInts printingInts = new();
        public ReturningStrings ReturningStrings { get; set; }

        public ConvertAdapter()
        {
            PrintingInts = printingInts;
        }

        public void GetString(ReturningStrings returningStrings)
        {
            var fetchedNumber = Int32.Parse(returningStrings.ReturnString());
            PrintingInts.Print(fetchedNumber);
        }
    }
}