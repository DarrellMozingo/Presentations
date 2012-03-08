namespace VisitorPattern
{
	public interface ICellVisitor
	{
		void Visit(ICell cell);
	}

	public class HtmlCellVisitor : ICellVisitor
	{
		public string Output { get; private set; }

		public void Visit(BoldCell boldCell)
		{
			Output += string.Format("<b>{0}</b>", boldCell.Text);
		}

		public void Visit(ItalicCell italicCell)
		{
			Output += string.Format("<i>{0}</i>", italicCell.Text);
		}

		public void Visit(ICell cell)
		{
			Visit((dynamic) cell);
		}
	}

	public class JsonCellVisitor : ICellVisitor
	{
		public string Output { get; private set; }

		public void Visit(BoldCell boldCell)
		{
			Output += string.Format("\"bold\" : \"{0}\"", boldCell.Text);
		}

		public void Visit(ItalicCell italicCell)
		{
			Output += string.Format("\"bold\" : \"{0}\"", italicCell.Text);
		}

		public void Visit(ICell cell)
		{
			Visit((dynamic)cell);
		}
	}
}