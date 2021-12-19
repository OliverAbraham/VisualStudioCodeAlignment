using System.Collections.Generic;
using System.Linq;
using Abraham.VisualStudio;

namespace VSIXProject4
{
	[Command(PackageIds.MyCommand)]
	internal sealed class MyCommand : BaseCommand<MyCommand>
	{
		protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
		{
			var docView = await VS.Documents.GetActiveDocumentViewAsync();
			var selection = docView.TextView.Selection.SelectedSpans.FirstOrDefault();
			if (selection == null)
				return;

			var fullLines = VSIXExtensionHelper.GetWholeLinesOfSelection(docView);
			var selectedText = VSIXExtensionHelper.GetSelectedText(docView);
			var newText = ProcessText(selectedText);
			docView.TextBuffer.Replace(selection, newText);
		}

		private string ProcessText(string text)
		{
			var aligner = new CSharpPropertyAligner();
			return aligner.AlignProperties(text);
		}
	}
}
