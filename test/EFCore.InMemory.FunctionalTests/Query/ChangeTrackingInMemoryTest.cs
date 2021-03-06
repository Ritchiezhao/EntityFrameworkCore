// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.TestUtilities;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class ChangeTrackingInMemoryTest : ChangeTrackingTestBase<NorthwindQueryInMemoryFixture<NoopModelCustomizer>>
    {
        public ChangeTrackingInMemoryTest(NorthwindQueryInMemoryFixture<NoopModelCustomizer> fixture)
            : base(fixture)
        {
        }
    }
}
