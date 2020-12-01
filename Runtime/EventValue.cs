using System;
using UnityEngine;

namespace EventValues
{
	public class EventValue<T>
	{
		[SerializeField]
		protected T _value = default;

		/// <summary>
		/// Call when value change
		/// </summary>
		public event Action<T> Event = default;

		protected void InvokeEvent()
		{
			Event?.Invoke(_value);
		}

		public EventValue() { }

		public EventValue(T value)
		{
			Value = value;
		}

		public virtual T Value
		{
			get
			{
				return _value;
			}

			set
			{
				if (!_value.Equals(value))
				{
					_value = value;
					Event?.Invoke(_value);
				}
			}
		}

		public override string ToString()
		{
			return _value.ToString();
		}
	}
}
