/*
Given a sentence, reverse the words of the sentence.For example,"i live in a house" becomes "house a in live i"
*/
using System.Text;

namespace InterviewCampProblems.Code {
    public class Class3 {

        public static string ReverseSentence (string sentence) {

            if (string.IsNullOrEmpty (sentence)) {
                System.Console.WriteLine ("Null or empty string");
                return sentence;
            }
            StringBuilder stringBuilder = new StringBuilder ();
            char[] arr = sentence.ToCharArray ();
            int length = 0;

            for (int i = arr.Length - 1; i >= 0; i--) {

                if (i == 0) {
                    stringBuilder.Append (sentence.Substring (i, length + 1));
                } else if (arr[i] == ' ') {
                    stringBuilder.Append (sentence.Substring (i + 1, length) + ' ');
                    length = 0;
                } else {
                    length++;
                }
            }
            return stringBuilder.ToString ();
        }
    }
}