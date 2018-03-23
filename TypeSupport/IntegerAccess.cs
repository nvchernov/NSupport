﻿namespace NSupport {    
    using System;

    /// <summary>
    /// Provides extension methods for <see cref="int"/> for easy access.
    /// </summary>
    public static class IntegerAccess {
        private static Action emptyAction = (() => { });
        private static Action<int> emptyIndexAction = ((i) => { });

        /// <summary>
        /// Loops the current <see cref="int" /> times with the given <paramref name="action"/>.
        /// </summary>
        /// <param name="source">A <see cref="int"/> instance.</param>
        /// <param name="action">A <see cref="Action" /> to loop.</param>
        public static void Times(this int source, Action action) {            
            source.Times((i) => { (action ?? emptyAction)(); });
        }

        /// <summary>
        /// Loops the current <see cref="int" /> times with the given <paramref name="action"/>.
        /// </summary>
        /// <param name="source">A <see cref="int"/> instance.</param>
        /// <param name="action">A <see cref="Action{T}" /> to loop.</param>
        public static void Times(this int source, Action<int> action) {            
            for (int i = 0; i < source; i++) {
                (action ?? emptyIndexAction)(i);
            }
        }

        /// <summary>
        /// Check if <paramref name="source"/> is null or has no elements.
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <returns></returns>
        public static bool IsBlank(this int? source) => source == null || source == default(int);

        /// <summary>
        /// Check if <paramref name="source"/> is not null and has any element.
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <returns></returns>
        public static bool IsPresent(this int? source) => source != null && source != default(int);

        /// <summary>
        /// Check if <paramref name="source"/> is null or has no elements.
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <returns></returns>
        public static bool IsBlank(this int source) => source == default(int);

        /// <summary>
        /// Check if <paramref name="source"/> is not null and has any element.
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <returns></returns>
        public static bool IsPresent(this int source) => source != default(int);

        /// <summary>
        /// Check if int is inside closed interval
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <param name="left">Left bound of interval</param>
        /// <param name="right">Right bound of interval</param>
        /// <returns></returns>
        public static bool IsInsideInterval(this int source, int left, int right)
        {
            return left <= source && source <= right;
        }

        /// <summary>
        /// Check if int is inside open interval (segment)
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <param name="left">Left bound of interval</param>
        /// <param name="right">Right bound of interval</param>
        /// <returns></returns>
        public static bool IsInsideSegment(this int source, int left, int right)
        {
            return left < source && source < right;
        }

        /// <summary>
        /// Check if int is inside closed interval
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <param name="left">Left bound of interval</param>
        /// <param name="right">Right bound of interval</param>
        /// <returns></returns>
        public static bool IsInsideInterval(this int? source, int? left, int? right)
        {
            return left <= source && source <= right;
        }

        /// <summary>
        /// Check if int is inside open interval (segment)
        /// </summary>
        /// <param name="source">An instance of <see cref="int"/>.</param>
        /// <param name="left">Left bound of interval</param>
        /// <param name="right">Right bound of interval</param>
        /// <returns></returns>
        public static bool IsInsideSegment(this int? source, int? left, int? right)
        {
            return left < source && source < right;
        }
    }
}