using UnityEngine;
using NumSharp;
using Unity.Barracuda;
using ns = NumSharp.np;

public class test : MonoBehaviour {
	public NNModel modelAsset;
	
	// Start is called before the first frame update
	private void Start() {
		var model = ModelLoader.Load(modelAsset);
		using var engine = WorkerFactory.CreateWorker(model, WorkerFactory.Device.GPU);

		using var input = ns.array(new float[] { 10, 1101, 19 }).AsTensor("input");
		var output = engine.Execute(input).PeekOutput();
		Debug.Log(output.AsNDArray().astype(typeof(bool), false));
	}
}