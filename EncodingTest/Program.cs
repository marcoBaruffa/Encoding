using System;
using System.Text;

namespace EncodingTest
{
    class Program
    {
        static void Main(string[] args)
        {


            string mydata = "Hello i am марчо";
            string mydataEncoded=EncodeTo64(mydata);
            Console.WriteLine(mydataEncoded);

            string myDataUnencoded = DecodeFrom64(mydataEncoded);
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(myDataUnencoded);

            Console.ReadLine();

            

        }

        private static string EncodeTo64(string toEncode)
        {

            byte[] ToEncodeAsBytes= Encoding.UTF8.GetBytes(toEncode);
            string returnValue= System.Convert.ToBase64String(ToEncodeAsBytes);

            return returnValue;

        }

        private static string DecodeFrom64(string encodeData)
        {

            byte[] encodeDataAsBytes = Convert.FromBase64String(encodeData);
            string returnValue = Encoding.UTF8.GetString(encodeDataAsBytes);
           

            return returnValue;

        }
    }
}
