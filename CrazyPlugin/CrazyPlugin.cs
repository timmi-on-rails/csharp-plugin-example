using PluginCommon;
using System;

namespace CrazyPlugin
{
	public class CrazyPlugin : IPlugin
	{
		public string Name => "Crazy Plugin";

		public void Init()
		{
			Console.WriteLine("Hello, this is the crazy plugin. Muhahaha!");
		}
	}
}
