namespace VisitorPattern
{
	public interface ICell
	{
		string Text { get; }
		void Accept(ICellVisitor cellVisitor);
	}

	public class BoldCell : ICell
	{
		public string Text
		{
			get { return "Bold Text"; }
		}

		public void Accept(ICellVisitor cellVisitor)
		{
			cellVisitor.Visit(this);
		}
	}

	public class NormalCell : ICell
	{
		public string Text
		{
			get { return ""; }
		}

		public void Accept(ICellVisitor cellVisitor)
		{
			cellVisitor.Visit(this);
		}
	}

	public class ItalicCell : ICell
	{
		public string Text
		{
			get { return "Italic Text"; }
		}

		public void Accept(ICellVisitor cellVisitor)
		{
			cellVisitor.Visit(this);
		}
	}
}