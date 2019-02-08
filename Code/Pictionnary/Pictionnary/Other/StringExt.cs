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
    public static class StringExt
    {
        /// <summary>
        /// Remove the diacritics from a string
        /// </summary>
        /// <param name="text">The text to modify</param>
        /// <returns>The text without the diacritics</returns>
        public static string RemoveDiacritics(this string text)
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
        /// Remove the special chars at the end of the string
        /// </summary>
        /// <param name="text">The text to modify</param>
        /// <returns>The text without special chars at the end</returns>
        public static string RemoveEnd(this string text)
        {
            return text;
        }

        public static string RemoveStartAndEndSpaces(this string text)
        {
            //While the first char is a space
            while (text[0] == ' ')
            {
                //Remove it
                text = text.Substring(1);
            }

            //While the last char is a space

            return text;
        }
    }
}
