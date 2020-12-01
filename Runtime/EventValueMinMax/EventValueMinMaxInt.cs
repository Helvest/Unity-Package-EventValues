using System;
using UnityEngine;

namespace EventValues
{
	[Serializable]
	public class EventValueMinMaxInt : EventValueInt
	{
		public EventValueMinMaxInt()
		{
			Value = _value;
		}

		public EventValueMinMaxInt(int value, int min, int max)
		{
			Set(value, min, max);
		}

		public void Set(int value, int min, int max)
		{
			_min = min;
			_max = max;
			Value = value;
		}

		public override int Value
		{
			get
			{
				return _value;
			}

			set
			{
				if (value < Min)
				{
					value = Min;
				}
				else if (value > Max)
				{
					value = Max;
				}

				if (_value != value)
				{
					_value = value;

					InvokeEvent();
				}
			}
		}

		[SerializeField]
		private int _min = default;
		public int Min
		{
			get
			{
				return _min;
			}

			set
			{
				_min = value;

				if (_value < _min)
				{
					_value = _min;

					InvokeEvent();
				}
			}
		}

		[SerializeField]
		private int _max = default;
		public int Max
		{
			get
			{
				return _max;
			}

			set
			{
				_max = value;

				if (_value > _max)
				{
					_value = _max;

					InvokeEvent();
				}
			}
		}
	}
}
