using System;
using UnityEngine;

namespace EventValues
{

	#region Types

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

	#endregion

	#region Unity struct

	[Serializable]
	public class EventValueVector2 : EventValue<Vector2> { }
	[Serializable]
	public class EventValueVector2Int : EventValue<Vector2Int> { }
	[Serializable]
	public class EventValueVector3 : EventValue<Vector3> { }
	[Serializable]
	public class EventValueVector3Int : EventValue<Vector3Int> { }
	[Serializable]
	public class EventValueVector4 : EventValue<Vector4> { }
	[Serializable]
	public class EventValueQuaternion : EventValue<Quaternion> { }

	#endregion

	#region Unity Class

	[Serializable]
	public class EventValueTransform : EventValue<Transform> { }
	[Serializable]
	public class EventValueGameObject : EventValue<GameObject> { }

	#endregion

}
