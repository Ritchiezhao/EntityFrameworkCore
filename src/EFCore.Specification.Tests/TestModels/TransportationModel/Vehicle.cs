// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.EntityFrameworkCore.TestModels.TransportationModel
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int SeatingCapacity { get; set; }
        public Operator Operator { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Vehicle;
            return other != null
                   && Name == other.Name
                   && SeatingCapacity == other.SeatingCapacity
                   && Equals(Operator, other.Operator);
        }

        public override int GetHashCode() => Name.GetHashCode();
    }
}
