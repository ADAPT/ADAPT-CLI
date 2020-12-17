using AgGateway.ADAPT.ApplicationDataModel.ADM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ADAPT_console.Utils
{
	public class ConsoleParameters
	{
		public string PluginsFolderPath { get; set; }

		public string ImportPluginName { get; set; }
		public string ImportPluginVersion { get; set; }
		public string ImportPluginPropertiesFile { get; set; }
		public string ImportDataPath { get; set; }

		public string ExportPluginName { get; set; }
		public string ExportPluginVersion { get; set; }
		public string ExportPluginPropertiesFile { get; set; }
		public string ExportDataPath { get; set; }
	}
}
