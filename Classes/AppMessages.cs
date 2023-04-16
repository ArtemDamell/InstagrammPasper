using System;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace InstagrammPasper.Classes
{
    public static class AppMessages
    {
        /// <summary>
        /// Sets the message in the resultTextBox. If isPlusEquals is true, the message is appended to the existing text.
        /// </summary>
        /// <param name="newMessage">The message to be set.</param>
        /// <param name="isPlusEquals">Whether the message should be appended to the existing text.</param>
        /// <param name="resultTextBox">The TextBox to set the message in.</param>
        public static void SetMessage(string newMessage, bool isPlusEquals, TextBox resultTextBox)
        {
            resultTextBox.Dispatcher.Invoke(() =>
            {
                if (!isPlusEquals)
                    resultTextBox.Text = newMessage;
                else
                    resultTextBox.AppendText($"\n{newMessage}");
                resultTextBox.ScrollToEnd();
            });
        }

        /// <summary>
        /// Replaces invalid characters with empty strings.
        /// </summary>
        /// <param name="strIn">The string to clean.</param>
        /// <returns>The cleaned string.</returns>
        public static string CleanInput(string strIn)
        {
            // Replace invalid characters with empty strings.
            try
            {
                return Regex.Replace(strIn, @"[^\w\s\.@-]", "",
                                     RegexOptions.None, TimeSpan.FromSeconds(1.5));
            }
            // If we timeout when replacing invalid characters,
            // we should return Empty.
            catch (RegexMatchTimeoutException)
            {
                return string.Empty;
            }
        }
    }
}
