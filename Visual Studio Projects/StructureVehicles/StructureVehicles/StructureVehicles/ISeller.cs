using System;
using System.Collections.Generic;
using System.Text;

namespace StructureVehicles
{
    /// <summary>
    /// Valid "interface name by microsoft standars, starts with a "I"
    /// An interface contains definitions for a group of related functionalities that a non-abstract class or a struct must implement
    /// </summary>
    public interface ISeller
    {
        int ZipCode { get; set; }
    }
}
