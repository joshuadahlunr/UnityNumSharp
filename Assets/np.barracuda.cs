using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Barracuda;

namespace NumSharp {
	public static class BarracudaInterop {
		public static TensorShape AsTensorShape(this Shape shape) {
			if (shape.Dimensions.Length > 8)
				throw new ArgumentException("Barracuda only supports tensors with up to 8 dimensions!");

			switch (shape.Dimensions.Length) {
				case 1: return new TensorShape(shape.Dimensions[0]);
				case 2: return new TensorShape(shape.Dimensions[0], shape.Dimensions[1]);
				case 3: return new TensorShape(shape.Dimensions[0], shape.Dimensions[1], shape.Dimensions[2]);
				case 4: return new TensorShape(shape.Dimensions[0], shape.Dimensions[1], shape.Dimensions[2], shape.Dimensions[3]);
				case 5: return new TensorShape(shape.Dimensions[0], shape.Dimensions[1], shape.Dimensions[2], shape.Dimensions[3], shape.Dimensions[4]);
			}

			// Barracuda requires that the shape be of size 8... so fill with 1s!
			var s = new List<int>(shape.Dimensions);
			while (s.Count < 8)
				s.Add(1);

			return new TensorShape(s.ToArray());
		}

		public static Shape AsNSShape(this TensorShape ts) {
			var shape = new List<int> { ts.numberOfDirections, ts.batch, ts.flatWidth / ts.depth / ts.height / ts.width / ts.channels, ts.depth, ts.height, ts.width, ts.channels };
			// Trim off any trailing 1s
			while (shape.Last() == 1)
				shape.RemoveAt(shape.Count - 1);
			// If we trimmed everything then we are dealing with a scalar!
			if (shape.Count == 0)
				shape.Add(1);

			return new Shape(shape.ToArray());
		}


		public static Tensor AsTensor(this NDArray array, string name = "", Tensor tensor = null) {
			var shape = array.Shape.AsTensorShape();

			tensor ??= new Tensor(shape, name);
			tensor.data.Upload(array.GetData<float>().ToArray(), shape);
			return tensor;
		}

		public static NDArray AsNDArray(this Tensor tensor) {
			var shape = tensor.shape;
			
			var array = np.array(tensor.data.Download(shape));
			return array.reshape(shape.AsNSShape());
						//.copy(); // TODO: Is the copy necessary?
		}
	}
}
