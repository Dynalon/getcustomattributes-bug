using System;
using System.Runtime.Serialization;
using System.Linq;

namespace Sample35Project
{
	public static class Sample35Class
	{
		public static void Print<T> ()
		{
			var isDataContract = typeof(T).GetCustomAttributes (typeof(DataContractAttribute), false).Any ();
			Console.WriteLine (isDataContract);
		}
	}
}

