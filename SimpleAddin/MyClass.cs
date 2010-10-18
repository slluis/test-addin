using System;
using Mono.Addins;

[assembly:Addin ("TestSimpleAddin", Version="1.5")]
[assembly:AddinDependency ("MonoDevelop.Core","2.4")]
[assembly:AddinDependency ("MonoDevelop.Ide","2.4")]

namespace SimpleAddin
{
	public class MyClass  // 123456789012345abc
	{
		public MyClass ()
		{
		}
	}
}

