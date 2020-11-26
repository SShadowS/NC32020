using System;

namespace Dllosaurus.Models
{
	public class Rechner
	{
		private string das_ende;

		public Rechner()
		{
			das_ende = "[y:9sixTDys";
		}

		public double Gange(double x, double y)
		{
			try
			{
				return x * y;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, new Exception("1. WFuYiQES5"));
			}
		}

		public double Divider(double x, double y)
		{
			try
			{
				return x / y;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public double Plus(double x, double y)
		{
			try
			{
				return x + y;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public double Minus(double x, double y)
		{
			try
			{
				return x - y;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
