using System;
using Refractored.Xam.Settings;
using ServiceStack.Text;
using PracticeWarning.Model;
using PracticeWarning.Model;

namespace PracticeWarning
{
	public interface IPersistenceService
	{
		void SetComplexValue<T> (string key, T val);

		T   GetComplexValue<T> (string key);

		void SetSimpleValue<T> (string key, T val);

		T GetSimpleValue<T> (string key);
	}

	public class PersistenceService:IPersistenceService
	{
		public PersistenceService ()
		{
		}

		public void SetSimpleValue<T> (string key, T val)
		{
			CrossSettings.Current.AddOrUpdateValue<T> (key, val);
		}

		public T GetSimpleValue<T> (string key)
		{
			return CrossSettings.Current.GetValueOrDefault<T> (key);
		}

		public void SetComplexValue<T> (string key, T val)
		{
			string json = JsonSerializer.SerializeToString<T> (val);
			CrossSettings.Current.AddOrUpdateValue (key, json);
		}

		public T   GetComplexValue<T> (string key)
		{
			string json = CrossSettings.Current.GetValueOrDefault<string> (key);
			return JsonSerializer.DeserializeFromString<T> (json);
		}
	}
}

