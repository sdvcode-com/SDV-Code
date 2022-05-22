// <copyright file="StringExtensions.cs" company="SDV Code Extension Methods">
// Copyright (c) SDV Code Extension Methods. All rights reserved.
// </copyright>

namespace SdvCode.ExtensionMethods
{
    using System.Text.RegularExpressions;

    public static class StringExtensions
    {
        public static string SplitCamelCase(this string source)
        {
            const string pattern = @"[A-Z][a-z]*|[a-z]+|\d+";
            var matches = Regex.Matches(source, pattern);
            return string.Join(" ", matches.Select(x => x.Value).ToList());
        }
    }
}