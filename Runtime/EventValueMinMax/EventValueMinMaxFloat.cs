using System;
using UnityEngine;

namespace EventValues
{
	[Serializable]
	public class EventValueMinMaxFloat : EventValueFloat
	{
		[SerializeField]
		protected float _min = default;
		[SerializeField]
		protected float _max = default;

		public EventValueMinMaxFloat(float startValue, float min, float max)
		{
			_min = min;
			_max = max;

			Value = startValue;
		}

		public override float Value
		{
			get
			{
				return _value;
			}

			set
			{
				if (value < _min)
				{
					value = _min;
				}
				else if (value > _max)
				{
					value = _max;
				}

				if (_value != value)
				{
					_value = value;

					InvokeEvent();
				}
			}
		}
	}
}
