﻿namespace ActiveSupport
{
    using System;

    /// <summary>
    /// Provide access methods for <see cref="Array"/>
    /// </summary>
    public static class ArrayAccess
    {
        /// <summary>
        /// The zero-based index of the first occurrence of value within the entire <paramref name="source"/>, if found; otherwise, –1.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">An instance of <see cref="Array"/>.</param>
        /// <param name="value">The object to locate in <paramref name="source"/>.</param>
        /// <returns>The zero-based index of the first occurrence of value within the entire <paramref name="source"/>, if found; otherwise, –1.</returns>
        public static int IndexOf<T>(this T[] source, T value)
        {
            if (source.IsBlank())
                return -1;

            return Array.IndexOf<T>(source, value);
        }

        /// <summary>
        /// The zero-based index of the last occurrence of value within the entire <paramref name="source"/>, if found; otherwise, –1.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">An instance of <see cref="Array"/>.</param>
        /// <param name="value">The object to locate in <paramref name="source"/>.</param>
        /// <returns>The zero-based index of the last occurrence of value within the entire <paramref name="source"/>, if found; otherwise, –1.</returns>
        public static int LastIndexOf<T>(this T[] source, T value)
        {
            if (source.IsBlank())
                return -1;

            return Array.LastIndexOf<T>(source, value);
        }

        /// <summary>
        /// Check if <paramref name="source"/> is null or has no elements.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">An instance of <see cref="Array"/>.</param>
        /// <returns></returns>
        public static bool IsBlank<T>(this T[] source)
        {
            return source == null || source.Length == 0;
        }

        /// <summary>
        /// Check if <paramref name="source"/> is not null and has any element.
        /// </summary>
        /// <typeparam name="T">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <param name="source">An instance of <see cref="Array"/>.</param>
        /// <returns></returns>
        public static bool IsPresent<T>(this T[] source)
        {
            return source != null && source.Length > 0;
        }

    }
}
