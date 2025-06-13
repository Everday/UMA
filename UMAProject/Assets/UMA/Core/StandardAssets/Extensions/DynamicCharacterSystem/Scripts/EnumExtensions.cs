using System;

namespace UMA.CharacterSystem
{
	public static class EnumExtensions
	{
		public static bool HasFlagSet(this Enum self, Enum flag)
		{
			if (self.GetType() != flag.GetType())
			{
				throw new ArgumentException("HasFlag : Flag is not of the type of Enum");
			}

			var selfValue = Convert.ToInt64(self);
			var flagValue = Convert.ToInt64(flag);

			return (selfValue & flagValue) == flagValue;
		}
	}
}
