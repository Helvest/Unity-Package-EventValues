using System;

namespace EventValues
{
	[Serializable]
	public class EventValueBool : EventValue<bool> { }
	[Serializable]
	public class EventValueByte : EventValue<byte> { }
	[Serializable]
	public class EventValueSByte : EventValue<sbyte> { }
	[Serializable]
	public class EventValueShort : EventValue<short> { }
	[Serializable]
	public class EventValueUShort : EventValue<ushort> { }
	[Serializable]
	public class EventValueInt : EventValue<int> { }
	[Serializable]
	public class EventValueUInt : EventValue<uint> { }
	[Serializable]
	public class EventValueLong : EventValue<long> { }
	[Serializable]
	public class EventValueULong : EventValue<ulong> { }
	[Serializable]
	public class EventValueFloat : EventValue<float> { }
	[Serializable]
	public class EventValueDouble : EventValue<double> { }
	[Serializable]
	public class EventValueDecimal : EventValue<decimal> { }
	[Serializable]
	public class EventValueChar : EventValue<char> { }
	[Serializable]
	public class EventValueString : EventValue<string> { }
}
