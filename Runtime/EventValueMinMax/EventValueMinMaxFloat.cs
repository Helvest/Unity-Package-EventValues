using System;
using UnityEngine;

namespace EventValues
{
	[Serializable]
	public class EventValueMinMaxFloat : EventValueFloat
	{
		public EventValueMinMaxFloat() : base()
		{
			Value = _value;
		}

		public EventValueMinMaxFloat(float value, float min, float max) : base()
		{
			Set(value, min, max);
		}

		public void Set(float value, float min, float max)
		{
			_min = min;
			_max = max;
			Value = value;
		}

		public override float Value
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
		private float _min = default;
		public float Min
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
		private float _max = default;
		public float Max
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
