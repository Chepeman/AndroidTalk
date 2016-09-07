using System;
namespace TalkExample
{
	public class Language
	{
		public string LanguageName { get; private set;}
		public string DeveloperCompany { get; private set; }
		public string ImageName { get; private set; }

		public Language(string languageName, string devCo, string imageName)
		{
			this.LanguageName = languageName;
			this.DeveloperCompany = devCo;
			this.ImageName = imageName;
		}
	}
}

