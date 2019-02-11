///ETML
///Author : Léa Cherpillod
///Date : 04.02.2019
///Description : The file containing the string extensions
using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace IndexatorusConnector.Helper.Extension
{
    /// <summary>
    /// The string extensions class
    /// </summary>
    public static class StringExt
    {
        /// <summary>
        /// Refactor a text by putting it into lower, removing extra spaces at the beginning or the end, diacritics, numbers and special chars except '-'
        /// </summary>
        /// <param name="text">The text to refactor</param>
        /// <returns>The refactored text</returns>
        public static string RefactorText(this string text)
        {
            //Return the refactored text
            return text.ToLower().RemoveDiacritics().RemoveSpecialChars().RemoveNumbers().Trim();
        }

        /// <summary>
        /// Remove the diacritics from a string
        /// </summary>
        /// <param name="text">The text to modify</param>
        /// <returns>The text without the diacritics</returns>
        private static string RemoveDiacritics(this string text)
        {
            //If the string is null or only contains spaces
            if (string.IsNullOrWhiteSpace(text))
                return text;

            //Decompose the text
            text = text.Normalize(NormalizationForm.FormD);

            //Get the category of the char
            var chars = text.Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();

            //Return the text by assembling the chars without their diacritics
            return new string(chars).Normalize(NormalizationForm.FormC);
        }
        
        /// <summary>
        /// Remove the special chars of the string except '-' 
        /// </summary>
        /// <param name="text">The text to modify</param>
        /// <returns>The text without special chars</returns>
        private static string RemoveSpecialChars(this string text)
        {
            StringBuilder newText = new StringBuilder();

            foreach (char chr in text)
            {
                //Check if the char is a letter or a digit, a - or a space
                if (Char.IsLetterOrDigit(chr) || chr == '-' || chr == ' ' || chr == '\'')
                    //If it is append it
                    newText.Append(chr);
            }

            //Return the stringbuilder as a string
            return newText.ToString();
        }
        
        /// <summary>
        /// Remove the numbers from a string
        /// </summary>
        /// <param name="text">The text to modify</param>
        /// <returns>The modified text</returns>
        private static string RemoveNumbers(this string text)
        {
            StringBuilder newText = new StringBuilder();

            foreach (char chr in text)
            {
                //Checi if the char is a letter or a digit, a - or a space
                if (!Char.IsDigit(chr))
                    //If it is append it
                    newText.Append(chr);
            }

            //Return the stringbuilder as a string
            return newText.ToString();
        }
        
    }
}
