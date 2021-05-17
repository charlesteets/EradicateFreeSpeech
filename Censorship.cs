using System;

namespace EradicateFreeSpeech
{
    public static class Censorship
    {
        /// <summary>
        /// A string extension method that determines whether speech should be censored.
        /// </summary>
        /// <value>
        /// The text to be analyzed and either censored or permitted.
        /// </value>
        /// <returns>
        /// true if the input should be censored, false if the input is permitted
        /// </returns>
        public static bool ShouldBeCensored(this string _)
        {
            return false;
        }
    }
}
