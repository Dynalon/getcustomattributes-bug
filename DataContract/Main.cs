using System;
using System.Runtime.Serialization;
using System.Linq;
using Sample35Project;

namespace Test
{
	[DataContract]
	public class MyClass
	{
		[DataMember (Name = "some-title")]
		string Title { get; set; }
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			Sample35Class.Print<MyClass> ();
		}
	}
}
