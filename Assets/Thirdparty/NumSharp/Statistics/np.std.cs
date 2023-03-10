using System;
using NumSharp.Backends;

namespace NumSharp
{
    public static partial class np
    {
        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="axis">Axis or axes along which the standard deviation is computed. The default is to compute the standard deviation of the flattened array.</param>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(NDArray a, bool keepdims = false, int? ddof = null, NPTypeCode? dtype = null)
        {
            return a.TensorEngine.ReduceStd(a, null, keepdims, ddof, dtype);
        }

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(in NDArray a, int? ddof = null)
            => a.TensorEngine.ReduceStd(a, null);

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="axis">Axis or axes along which the standard deviation is computed. The default is to compute the standard deviation of the flattened array.</param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(in NDArray a, int axis, int? ddof = null)
            => a.TensorEngine.ReduceStd(a, axis, ddof: ddof);

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(in NDArray a, bool keepdims, int? ddof = null)
            => a.TensorEngine.ReduceStd(a, null, keepdims, ddof: ddof);

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="axis">Axis or axes along which the standard deviation is computed. The default is to compute the standard deviation of the flattened array.</param>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(in NDArray a, int axis, Type dtype, bool keepdims = false, int? ddof = null)
            => a.TensorEngine.ReduceStd(a, axis, keepdims, ddof, dtype != null ? dtype.GetTypeCode() : (NPTypeCode?)null);

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="axis">Axis or axes along which the standard deviation is computed. The default is to compute the standard deviation of the flattened array.</param>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(in NDArray a, int axis, NPTypeCode type, bool keepdims = false, int? ddof = null)
            => a.TensorEngine.ReduceStd(a, axis, keepdims, ddof, type);

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="axis">Axis or axes along which the standard deviation is computed. The default is to compute the standard deviation of the flattened array.</param>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(in NDArray a, int axis, bool keepdims, int? ddof = null)
            => a.TensorEngine.ReduceStd(a, axis, keepdims, ddof: ddof);

        /// <summary>
        ///     Compute the standard deviation along the specified axis.
        ///     Returns the standard deviation, a measure of the spread of a distribution, of the array elements. The standard deviation is computed for the flattened array by default, otherwise over the specified axis.
        /// </summary>
        /// <param name="a">Calculate the standard deviation of these values.</param>
        /// <param name="axis">Axis or axes along which the standard deviation is computed. The default is to compute the standard deviation of the flattened array.</param>
        /// <param name="keepdims">
        ///     If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array.
        /// </param>
        /// <param name="ddof">Means Delta Degrees of Freedom. The divisor used in calculations is N - ddof, where N represents the number of elements. By default ddof is zero.</param>
        /// <returns> returns a new array containing the std values, otherwise a reference to the output array is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.std.html</remarks>
        public static NDArray std(NDArray a, int axis, bool keepdims = false, int? ddof = null, NPTypeCode? dtype = null)
        {
            return a.TensorEngine.ReduceStd(a, axis, keepdims, ddof, dtype);
        }
    }
}
