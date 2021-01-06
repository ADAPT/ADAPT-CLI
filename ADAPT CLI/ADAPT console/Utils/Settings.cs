using AgGateway.ADAPT.ApplicationDataModel.ADM;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADAPT_console.Utils
{
	public class Settings
	{
		public string InitialiseString { get; set; }
		public Dictionary<string, string> Properties { get; set; }

		public Properties GetProperties()
		{
			Properties prop = new Properties();
			foreach (var property in Properties)
			{
				prop.SetProperty(property.Key, property.Value);
			}
			return prop;
		}
	}
}
