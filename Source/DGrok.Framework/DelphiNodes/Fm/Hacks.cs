using System;

namespace DGrok.DelphiNodes
{
	internal static class Hacks
	{
		private const StringComparison Inv = StringComparison.InvariantCultureIgnoreCase;

		public static bool NeedsHack(string fileName)
			=> fileName.EndsWith(".dfm", Inv);

		public static string ApplyPatch(string text)
		{
			int index;
			var tmp = "= {";
			while ((index = text.IndexOf(tmp, Inv)) >= 1)
			{
				var close = text.IndexOf('}', index);
				text = text.Remove(close, 1);
				text = text.Insert(close, ")_");
				text = text.Remove(index + 2, 1);
				text = text.Insert(index + 2, "_(");
			}
			tmp = "' +";
			while ((index = text.IndexOf(tmp, Inv)) >= 1)
			{
				var close = text.IndexOf('\'', index + 1);
				text = text.Remove(index, close - index + 1);
			}
			tmp = "ReadOnly = ";
			if (text.Contains(tmp))
			{
				text = text.Replace(tmp, $"r{tmp}");
			}
			return text;
		}
	}
}