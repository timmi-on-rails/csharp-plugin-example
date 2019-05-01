using PluginCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace PluginExample
{
	static class PluginLoader
	{
		public static ICollection<IPlugin> LoadPlugins(string searchDirectory)
		{
			ICollection<IPlugin> plugins = new List<IPlugin>();
			Type pluginInterfaceType = typeof(IPlugin);

			foreach (string dllFile in Directory.GetFiles(searchDirectory, "*.dll"))
			{
				Assembly assembly = Assembly.LoadFile(dllFile);

				Type[] types = assembly.GetTypes();

				foreach (Type type in types)
				{
					if (!type.IsAbstract &&
						(type.GetConstructor(Type.EmptyTypes) != null) &&
						pluginInterfaceType.IsAssignableFrom(type))
					{
						IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
						plugins.Add(plugin);
					}
				}
			}

			return plugins;
		}
	}
}
