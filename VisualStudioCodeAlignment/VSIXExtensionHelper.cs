using System.Collections.Generic;
using System.Linq;

namespace Abraham.VisualStudio
{
	internal class VSIXExtensionHelper
	{
		#region ------------- Methods -------------------------------------------------------------
		public static string GetSelectedText(DocumentView docView)
		{
			var selection = docView.TextView.Selection.SelectedSpans.FirstOrDefault();
			if (selection == null)
				return "";
			var selectedText = selection.GetText();
			return selectedText;
		}

		public static List<string> GetWholeLinesOfSelection(DocumentView docView)
		{
			var selection = docView.TextView.Selection.SelectedSpans.FirstOrDefault();
			if (selection == null)
				return new List<string>();

			var startLineNumber = selection.Start.GetContainingLineNumber();
			var endngLineNumber = selection.End.GetContainingLineNumber();
			var wholeLines = GetFullLinesBetween(docView, startLineNumber, endngLineNumber);
			return wholeLines;
		}

		public static List<string> GetFullLinesBetween(DocumentView docView, int startLineNumber, int endLineNumber)
		{
			var lines = docView.TextView.TextViewLines;

			var fullLines = new List<string>();
			for (int line = startLineNumber; line <= endLineNumber; line++)
			{
				var textViewLine = lines[line];
				var fullLine = textViewLine.Extent.GetText();
				fullLines.Add(fullLine);
			}

			return fullLines;
		}
		#endregion
	}
}
