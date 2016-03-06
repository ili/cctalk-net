using dk.CctalkLib.Annotations;

namespace dk.CctalkLib.Misc
{
	/// <summary> </summary>
	public struct ScalingFactor
	{
		/// <summary> </summary>
		[UsedImplicitly]
		public byte ScalingFactor_LSB;
		/// <summary> </summary>
		[UsedImplicitly]
		public byte ScalingFactor_MSB;
		/// <summary> </summary>
		[UsedImplicitly]
		public byte DecimalPlaces;
	}
}