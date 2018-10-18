using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace SunRoseWMS.Localization
{
    public static class SunRoseWMSLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(SunRoseWMSConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(SunRoseWMSLocalizationConfigurer).GetAssembly(),
                        "SunRoseWMS.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
