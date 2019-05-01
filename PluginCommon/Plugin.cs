namespace PluginCommon
{
	/// <summary>
	/// All plugins need to implement this interface.
	/// </summary>
	public interface IPlugin
	{
		/// <summary>
		/// Short name of the plugin.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Called once the plugin gets loaded by the application.
		/// </summary>
		void Init();
	}
}
