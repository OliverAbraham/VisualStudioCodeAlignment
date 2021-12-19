namespace Abraham.VisualStudio
{
	internal class LineObject
	{
		#region ------------- Properties ----------------------------------------------------------
		public string[] Columns { get; set; }
		public int[]    ColumnWidths { get; set; }
		public string[] FormattedColumns { get; set; }
		#endregion



		#region ------------- Init ----------------------------------------------------------------
		public LineObject(string line)
		{
			line = ReplaceTabsWithSpaces(line);

			var columns = line.Split(new char[] { ' ' });
			var columnCount = columns.GetLength(0);

			Columns = SplitStringIntoColumns(line, columnCount);

			FormattedColumns = new string[Columns.GetLength(0)];
		}
		#endregion



		#region ------------- Methods -------------------------------------------------------------
		public int GetColumnCount()
		{
			return Columns.GetLength(0);
		}

		public int GetColumnWidth(int index)
		{
			if (ColumnWidths.GetLength(0) > index)
				return ColumnWidths[index];
			else
				return 0;
		}

		public void ReformatColumn(int colIndex, int newWidth)
		{
			if (FormattedColumns.GetLength(0) <= colIndex ||
				Columns         .GetLength(0) <= colIndex)
				return;

			FormattedColumns[colIndex] = Columns[colIndex];
			var currentWidth = Columns[colIndex].Length;
			var delta = newWidth - currentWidth;
			while (currentWidth < newWidth)
			{
				FormattedColumns[colIndex] += " ";
				currentWidth++;
			}
		}

		public override string ToString()
		{
			return string.Join("", FormattedColumns);
		}
		#endregion



		#region ------------- Implementation ------------------------------------------------------
		/// <summary>
		/// Split a given string into column, 
		/// but unlike the "Split" method by preserving all spaces.
		/// The sum of all columns hat the same length as the input string.
		/// </summary>
		private string[] SplitStringIntoColumns(string line, int columnCount)
		{
			var columns = new string[columnCount];
			ColumnWidths = new int[columnCount];
			bool weAreInWhitespace = false;
			bool weAreInAngleBrackets = false;
			int colIndex = 0;

			foreach (var chr in line)
			{
				if (weAreInAngleBrackets)
				{
					columns[colIndex] += chr;
					if (chr == '>')
						weAreInAngleBrackets = false;
				}
				else
				{
					if (!weAreInWhitespace)
					{
						if (chr == ' ')
							weAreInWhitespace = true;
					}
					else
					{
						if (chr != ' ' && weAreInWhitespace)
						{
							weAreInWhitespace = false;
							ColumnWidths[colIndex] = columns[colIndex].Length;
							colIndex++;
						}
					}
					columns[colIndex] += chr;

					if (chr == '<')
						weAreInAngleBrackets = true;
				}
			}

			return ResizeArrayTo(columns, colIndex + 1);
		}

		private string[] ResizeArrayTo(string[] columns, int newSize)
		{
			var newArray = new string[newSize];
			
			for (int i = 0; i < newSize; i++)
				newArray[i] = columns[i];
			
			return newArray;
		}

		private string ReplaceTabsWithSpaces(string line)
		{
			return line.Replace("\t", "    ");
		}
		#endregion
	}
}
