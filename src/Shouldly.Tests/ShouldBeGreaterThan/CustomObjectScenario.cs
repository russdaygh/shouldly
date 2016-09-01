﻿using Shouldly.Tests.TestHelpers;
using Xunit;

namespace Shouldly.Tests.ShouldBeGreaterThan
{
    public class CustomObjectScenario
    {
        [Fact]
        public void CompareCustom()
        {
            var customA = new Custom { Val = 2 };
            var customB = new Custom { Val = 1 };
            var comparer = new CustomComparer<Custom>();
            customA.ShouldBeGreaterThan(customB, comparer);
        }
    }
}
