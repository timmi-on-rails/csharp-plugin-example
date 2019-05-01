using PluginCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PluginExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Searching for plugins in current directory...");

			ICollection<IPlugin> plugins = PluginLoader.LoadPlugins(Directory.GetCurrentDirectory());

			Console.WriteLine($"Found {plugins.Count} plugin(s).");

			foreach(IPlugin plugin in plugins)
			{
				Console.WriteLine($"Initializing plugin with name '{plugin.Name}'...");
				plugin.Init();
			}

			Console.ReadKey();
		}
	}
}
