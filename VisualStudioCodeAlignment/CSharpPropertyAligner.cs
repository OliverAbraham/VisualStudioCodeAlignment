using System.Collections.Generic;
using System.Linq;

namespace Abraham.VisualStudio
{
	internal class CSharpPropertyAligner
	{
		#region ------------- Methods -------------------------------------------------------------
		public string AlignProperties(string text)
		{
			var lines = text.Split(new[] { '\r', '\n' });
			var lineObjects = ConvertLinesToObjects(lines.ToList());
			return string.Join("\r\n", lineObjects.Select(x => x.ToString()));
		}

		public string AlignProperties(List<string> lines)
		{
			var lineObjects = ConvertLinesToObjects(lines);
			return string.Join("\r\n", lineObjects.Select(x => x.ToString()));
		}
		#endregion



		#region ------------- Implementation ------------------------------------------------------
		private List<LineObject> ConvertLinesToObjects(List<string> lines)
		{
			var lineObjects = new List<LineObject>();

			foreach (var line in lines)
			{
				if (!string.IsNullOrEmpty(line))
					lineObjects.Add(new LineObject(line));
			}

			var totalColumnCountOfAllLines = lineObjects.Select(x => x.GetColumnCount()).Max();
			
			for (int i = 0; i < totalColumnCountOfAllLines; i++)
			{
				var allWidthsOfThisColumn = lineObjects.Select(x => x.GetColumnWidth(i));
				var maxWidth = allWidthsOfThisColumn.Max();

				foreach (var obj in lineObjects)
					obj.ReformatColumn(i, maxWidth);
			}

			return lineObjects;
		}
		#endregion
	}
}
