﻿namespace ActiveSupport.Test
{
    using System;
    using Xunit;

    public class ArrayAccessTest
    {
        [Fact]
        public void Test_IndexOf_with_null()
        {
            int[] nullArray = null;
            Assert.Equal(-1, nullArray.IndexOf(1));
        }

        [Fact]
        public void Test_IndexOf_with_existing_value()
        {
            var ints = new[] { 1, 2, 3, 4, 5, 1 };
            Assert.Equal(0, ints.IndexOf(1));
        }

        [Fact]
        public void Test_IndexOf_with_non_existing_value()
        {
            var ints = new[] { 1, 2, 3, 4, 5 };
            Assert.Equal(-1, ints.IndexOf(7));
        }

        [Fact]
        public void Test_LastIndexOf_with_null()
        {
            int[] nullArray = null;
            Assert.Equal(-1, nullArray.LastIndexOf(1));
        }

        [Fact]
        public void Test_LastIndexOf_with_existing_value()
        {
            var ints = new[] { 1, 2, 3, 4, 5, 1 };
            Assert.Equal(5, ints.LastIndexOf(1));
        }

        [Fact]
        public void Test_LastIndexOf_with_non_existing_value()
        {
            var ints = new[] { 1, 2, 3, 4, 5, 1 };
            Assert.Equal(-1, ints.LastIndexOf(7));
        }

        [Fact]
        public void Test_IsBlank_with_null()
        {
            int[] ints = null;

            Assert.Equal(true, ints.IsBlank());
        }

        [Fact]
        public void Test_IsBlank_with_no_elements()
        {
            int[] ints = new int[0];

            Assert.Equal(true, ints.IsBlank());
        }

        [Fact]
        public void Test_IsBlank_with_elements()
        {
            int[] ints = new int[1] { 1 };

            Assert.Equal(false, ints.IsBlank());
        }

        [Fact]
        public void Test_IsPresent_with_null()
        {
            int[] ints = null;

            Assert.Equal(false, ints.IsPresent());
        }

        [Fact]
        public void Test_IsPresent_with_no_elements()
        {
            int[] ints = new int[0];

            Assert.Equal(false, ints.IsPresent());
        }

        [Fact]
        public void Test_IsPresent_with_elements()
        {
            int[] ints = new int[1] { 1 };

            Assert.Equal(true, ints.IsPresent());
        }

    }
}
