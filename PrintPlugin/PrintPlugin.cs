using PluginCommon;
using System;

namespace PrintPlugin
{
	public class PrintPlugin : IPlugin
	{
		public string Name => "Print Plugin";

		public void Init()
		{
			Console.WriteLine("It's me the printer!");
		}
	}
}
