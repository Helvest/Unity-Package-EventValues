using System;
using UnityEngine;

namespace EventValues
{
	[Serializable]
	public class EventValueMinMaxInt : EventValueInt
	{
		[SerializeField]
		protected int _min = default;
		[SerializeField]
		protected int _max = default;

		public EventValueMinMaxInt(int startValue, int min, int max)
		{
			_min = min;
			_max = max;

			Value = startValue;
		}

		public override int Value
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
