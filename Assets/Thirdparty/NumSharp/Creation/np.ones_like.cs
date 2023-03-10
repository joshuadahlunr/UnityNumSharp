using System;

namespace NumSharp
{
    public static partial class np
    {
        /// <summary>
        ///     Return an array of ones with the same shape and type as a given array.
        /// </summary>
        /// <param name="a">Array of ones with the same shape and type as a.</param>
        /// <param name="dtype">Overrides the data type of the result.</param>
        /// <returns>Array of zeros with the same shape and type as `nd`.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.ones_like.html</remarks>
        public static NDArray ones_like(NDArray a, Type dtype = null)
        {
            return np.ones(new Shape(a.shape), dtype ?? a.dtype);
        }
    }
}
