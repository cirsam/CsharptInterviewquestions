namespace testsinterview
{
    public static class Factory
    {
        public static MergeStringsOrStringInterlace CreateMergeStringsOrStringInterlace(){

            return new MergeStringsOrStringInterlace();

        }

        public static CountEvenAndOddNumbersInArray CreateCountEvenAndOddNumbersInArray()
        {

            return new CountEvenAndOddNumbersInArray();

        }

        public static GetFirstStringThatDoesNotRepeat CreateGetFirstStringThatDoesNotRepeat()
        {

            return new GetFirstStringThatDoesNotRepeat();

        }

        public static FindAndReplaceMissingString FindAndReplaceMissingString()
        {

            return new FindAndReplaceMissingString();

        }
    }
}
