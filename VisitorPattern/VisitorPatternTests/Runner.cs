using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace VisitorPattern
{
	public class Runner
	{
		[Test]
		public void HtmlFormatter()
		{
			var cells = new List<ICell> {new BoldCell(), new ItalicCell(), new BoldCell()};

			var htmlFormatter = new HtmlCellVisitor();

			foreach(var cell in cells)
			{
				cell.Accept(htmlFormatter);
			}

			Console.WriteLine(htmlFormatter.Output);
		}

		[Test]
		public void JsonFormatter()
		{
			var cells = new List<ICell> {new BoldCell(), new ItalicCell(), new BoldCell()};

			var jsonFormatter = new JsonCellVisitor();

			foreach(var cell in cells)
			{
				cell.Accept(jsonFormatter);
			}

			Console.WriteLine(jsonFormatter.Output);
		}
	}
}