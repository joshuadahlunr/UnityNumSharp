using System;
using NumSharp.Backends;

namespace NumSharp
{
    public static partial class np
    {
        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="dtype">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a)
            => a.TensorEngine.Sum(a, axis: null, typeCode: null, keepdims: false);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="dtype">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, int axis)
            => a.TensorEngine.Sum(a, axis: axis, typeCode: null, keepdims: false);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="dtype">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, bool keepdims)
            => a.TensorEngine.Sum(a, axis: null, typeCode: null, keepdims: keepdims);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="dtype">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, int? axis, bool keepdims)
            => a.TensorEngine.Sum(a, axis: axis, typeCode: null, keepdims: keepdims);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="dtype">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, int? axis, bool keepdims, Type dtype)
            => a.TensorEngine.Sum(a, axis: axis, typeCode: dtype?.GetTypeCode(), keepdims: keepdims);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="typeCode">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, int? axis, bool keepdims, NPTypeCode? typeCode)
            => a.TensorEngine.Sum(a, axis: axis, typeCode: typeCode, keepdims: keepdims);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="dtype">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, int? axis, Type dtype)
            => a.TensorEngine.Sum(a, axis: axis, typeCode: dtype?.GetTypeCode(), keepdims: false);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="typeCode">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, int? axis, NPTypeCode? typeCode)
            => a.TensorEngine.Sum(a, axis: axis, typeCode: typeCode, keepdims: false);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="dtype">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, Type dtype)
            => a.TensorEngine.Sum(a, axis: null, typeCode: dtype?.GetTypeCode(), keepdims: false);

        /// <summary>
        ///     Sum of array elements over a given axis.
        /// </summary>
        /// <param name="a">Elements to sum.</param>
        /// <param name="axis">Axis or axes along which a sum is performed. The default, axis=None, will sum all of the elements of the input array. If axis is negative it counts from the last to the first axis. </param>
        /// <param name="typeCode">The type of the returned array and of the accumulator in which the elements are summed. The dtype of a is used by default unless a has an integer dtype of less precision than the default platform integer. In that case, if a is signed then the platform integer is used while if a is unsigned then an unsigned integer of the same precision as the platform integer is used.</param>
        /// <param name="keepdims">If this is set to True, the axes which are reduced are left in the result as dimensions with size one. With this option, the result will broadcast correctly against the input array. If the default value is passed, then keepdims will not be passed through to the sum method of sub-classes of ndarray, however any non-default value will be.If the sub-class’ method does not implement keepdims any exceptions will be raised.</param>
        /// <returns>An array with the same shape as a, with the specified axis removed. If a is a 0-d array, or if axis is None, a scalar is returned. If an output array is specified, a reference to out is returned.</returns>
        /// <remarks>https://docs.scipy.org/doc/numpy/reference/generated/numpy.sum.html</remarks>
        public static NDArray sum(in NDArray a, NPTypeCode? typeCode)
            => a.TensorEngine.Sum(a, axis: null, typeCode: typeCode, keepdims: false);
    }
}