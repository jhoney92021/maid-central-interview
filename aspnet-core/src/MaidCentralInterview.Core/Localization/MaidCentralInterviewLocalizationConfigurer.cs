using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MaidCentralInterview.Localization
{
    public static class MaidCentralInterviewLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MaidCentralInterviewConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MaidCentralInterviewLocalizationConfigurer).GetAssembly(),
                        "MaidCentralInterview.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
