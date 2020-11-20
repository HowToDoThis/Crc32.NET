﻿#if !NET
namespace Force.Crc32.Tests.Crc32Implementations
{
	public class Crc32_Crc32Algorithm : CrcCalculator
	{
		public Crc32_Crc32Algorithm() : base("Crc32.Crc32Algorithm")
		{ }

		public override uint Calculate(byte[] data)
		{
			return Crc32Algorithm.Compute(data);
		}
	}
}
#endif