using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for Items that can be blended
    /// </summary>
    /// <returns></returns>
    interface IBlendable
    {
        /// <summary>
        /// Blends the object
        /// </summary>
        /// <returns>A string of blended object results</returns>
        string Blend();
    }
}
